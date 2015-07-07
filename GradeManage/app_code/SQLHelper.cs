using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Web;
using System.Web.Security;


/// <summary>
/// SQLHelper类封装对SQL Server数据库的添加、删除、修改和选择等操作
/// </summary>
public class SQLHelper
{
    /// 连接数据源
    private SqlConnection myConnection = null;
    private readonly string RETURNVALUE = "RETURNVALUE";

    /// <summary>
    /// 打开数据库连接.
    /// </summary>
    private void Open()
    {
        // 打开数据库连接
        if (myConnection == null)
        {
            myConnection = new System.Data.SqlClient.SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DbConnect"].ToString());
        }
        if (myConnection.State == ConnectionState.Closed)
        {
            try
            {
                ///打开数据库连接
                myConnection.Open();
            }
            catch (Exception ex)
            {
                //SystemError.CreateErrorLog(ex.Message);
            }
            finally
            {
                ///关闭已经打开的数据库连接				
            }
        }
    }

    /// <summary>
    /// 关闭数据库连接
    /// </summary>
    public void Close()
    {
        ///判断连接是否已经创建
        if (myConnection != null)
        {
            ///判断连接的状态是否打开
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }
    }

    /// <summary>
    /// 释放资源
    /// </summary>
    public void Dispose()
    {
        // 确认连接是否已经关闭
        if (myConnection != null)
        {
            myConnection.Dispose();
            myConnection = null;
        }
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <returns>返回存储过程返回值</returns>
    public int RunProc(string procName)
    {
        SqlCommand cmd = CreateProcCommand(procName, null);
        try
        {
            ///执行存储过程
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }

        ///返回存储过程的参数值
        return (int)cmd.Parameters[RETURNVALUE].Value;
    }

    /// <summary>
    /// 执行多条无返回值的SQL数据库操作
    /// </summary>
    /// <param name="sqlstring"></param>
    /// <returns></returns>
    public bool UpdateMore(string[][] sqlstring)
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DbConnect"].ToString());
        SqlCommand cmd = new SqlCommand();
        int i = sqlstring.Length; //获取字符串数组中字符串的个数
        try
        {
            conn.Open();     //打开数据库
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            throw new Exception(e.Message);   //抛出异常
        }
        SqlTransaction uptans = conn.BeginTransaction();
        try
        {
            cmd.Connection = conn;  //确定数据库连接
            cmd.Transaction = uptans; //确定Transaction属性为新建的uptans
            foreach (string[] str in sqlstring)
            {
                foreach (string sql in str)
                {
                    cmd.CommandText = sql; //分别取出每个字符串作为操作的命令
                    cmd.ExecuteNonQuery();//执行数据库操作命令
                }
            }

            uptans.Commit();//执行完字符串数组中指定的所有命令后提交
            return true;
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            uptans.Rollback();
            throw new Exception(e.Message);
        }
        finally
        {
            cmd.Dispose();   //释放该组件占用的资源
            conn.Close();   //关闭数据库连接
        }
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <returns>返回存储过程返回值</returns>
    public int RunProc(string procName, SqlParameter[] prams)
    {
        SqlCommand cmd = CreateProcCommand(procName, prams);
        //try
        //{
            ///执行存储过程
            cmd.ExecuteNonQuery();
        //}
        //catch (Exception ex)
        //{
        //    //记录错误日志
        //    //SystemError.CreateErrorLog(ex.Message);
        //    throw new Exception(ex.Message);   //抛出异常
        //}
        //finally
        //{
            ///关闭数据库的连接
            Close();
        //}

        ///返回存储过程的参数值
        return (int)cmd.Parameters[RETURNVALUE].Value;
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="dataReader">返回DataReader对象</param>
    public void RunProc(string procName, ref SqlDataReader dataReader)
    {
        ///创建Command
        SqlCommand cmd = CreateProcCommand(procName, null);

        try
        {
            ///读取数据
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            dataReader = null;
            //记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <param name="dataSet">返回DataReader对象</param>
    public void RunProc(string procName, SqlParameter[] prams, out SqlDataReader dataReader)
    {
        ///创建Command
        SqlCommand cmd = CreateProcCommand(procName, prams);

        try
        {
            ///读取数据
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            dataReader = null;
            //记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="dataSet">返回DataSet对象</param>
    public void RunProc(string procName, ref DataSet dataSet)
    {
        if (dataSet == null)
        {
            dataSet = new DataSet();
        }
        ///创建SqlDataAdapter
        SqlDataAdapter da = CreateProcDataAdapter(procName, null);

        try
        {
            ///读取数据
            da.Fill(dataSet);
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }
    }

    /// <summary>
    /// 公有方法，获取数据，返回一个DataRow。
    /// </summary>
    /// <param name="SqlString">Sql语句</param>
    /// <returns>DataRow</returns>
    public DataRow GetDataRow(String SqlString)
    {
        DataSet dataset = new DataSet();
        RunSQL(SqlString, ref dataset);
        dataset.CaseSensitive = false;
        if (dataset.Tables[0].Rows.Count > 0)
        {
            return dataset.Tables[0].Rows[0];
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// 执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <param name="dataSet">返回DataSet对象</param>
    public void RunProc(string procName, SqlParameter[] prams, ref DataSet dataSet)
    {
        if (dataSet == null)
        {
            dataSet = new DataSet();
        }
        ///创建SqlDataAdapter
        SqlDataAdapter da = CreateProcDataAdapter(procName, prams);

        try
        {
            ///读取数据
            da.Fill(dataSet);
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }
    }

    /// <summary>
    /// 执行无返回值SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <returns>返回值</returns>
    public int RunSQL(string cmdText)
    {
        SqlCommand cmd = CreateSQLCommand(cmdText, null);
        cmd.ExecuteNonQuery();
        //try
        //{
        //    ///执行存储过程
        //    cmd.ExecuteNonQuery();
        //}
        //catch (Exception ex)
        //{
        //    ///记录错误日志
        //    //SystemError.CreateErrorLog(ex.Message);
        //}
        //finally
        //{
        //    ///关闭数据库的连接
        //    Close();
        //}

        ///返回存储过程的参数值
        return (int)cmd.Parameters[RETURNVALUE].Value;
    }

    /// <summary>
    /// 执行SQL语句，并返回第一行第一列结果
    /// </summary>
    /// <param name="strSql">SQL语句</param>
    /// <returns></returns>
    public string RunSqlReturn(string cmdText)
    {
        string strReturn = "";
        SqlCommand cmd = CreateSQLCommand(cmdText, null);
        //cmd.ExecuteNonQuery();
        try
        {
            ///执行存储过程
            strReturn = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }

        ///返回存储过程的参数值
        return strReturn;
    }
    /// <summary>
    /// 执行SQL语句，并返回第一行第一列结果
    /// </summary>
    /// <param name="strSql">SQL语句</param>
    /// <returns></returns>
    public string RunSqlReturn(string cmdText, SqlParameter[] prams)
    {
        string strReturn = "";
        SqlCommand cmd = CreateSQLCommand(cmdText, prams);
        //cmd.ExecuteNonQuery();
        try
        {
            ///执行存储过程
            strReturn = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }

        ///返回存储过程的参数值
        return strReturn;
    }
    /// <summary>
    /// 执行无返回值的SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="prams">SQL语句所需参数</param>
    /// <returns>返回值</returns>
    public int RunSQL(string cmdText, SqlParameter[] prams)
    {
        SqlCommand cmd = CreateSQLCommand(cmdText, prams);
        try
        {
            ///执行存储过程
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }

        ///返回存储过程的参数值
        return (int)cmd.Parameters[RETURNVALUE].Value;
    }

    /// <summary>
    /// 执行SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>		
    /// <param name="dataReader">返回DataReader对象</param>
    public void RunSQL(string cmdText, out SqlDataReader dataReader)
    {
        ///创建Command
        SqlCommand cmd = CreateSQLCommand(cmdText, null);

        try
        {
            ///读取数据
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            dataReader = null;
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
    }

    /// <summary>
    /// 执行SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="prams">SQL语句所需参数</param>
    /// <param name="dataReader">返回DataReader对象</param>
    public void RunSQL(string cmdText, SqlParameter[] prams, out SqlDataReader dataReader)
    {
        ///创建Command
        SqlCommand cmd = CreateSQLCommand(cmdText, prams);

        try
        {
            ///读取数据
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            dataReader = null;
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
    }

    /// <summary>
    /// 执行SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="dataSet">返回DataSet对象</param>
    public void RunSQL(string cmdText, ref DataSet dataSet)
    {
        if (dataSet == null)
        {
            dataSet = new DataSet();
        }
        ///创建SqlDataAdapter
        SqlDataAdapter da = CreateSQLDataAdapter(cmdText, null);

        try
        {
            ///读取数据
            da.Fill(dataSet);
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }
    }

    /// <summary>
    /// 执行SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="prams">SQL语句所需参数</param>
    /// <param name="dataSet">返回DataSet对象</param>
    public void RunSQL(string cmdText, SqlParameter[] prams, ref DataSet dataSet)
    {
        if (dataSet == null)
        {
            dataSet = new DataSet();
        }
        ///创建SqlDataAdapter
        SqlDataAdapter da = CreateProcDataAdapter(cmdText, prams);

        try
        {
            ///读取数据
            da.Fill(dataSet);
        }
        catch (Exception ex)
        {
            ///记录错误日志
            //SystemError.CreateErrorLog(ex.Message);
        }
        finally
        {
            ///关闭数据库的连接
            Close();
        }
    }

    /// <summary>
    /// 创建一个SqlCommand对象以此来执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <returns>返回SqlCommand对象</returns>
    private SqlCommand CreateProcCommand(string procName, SqlParameter[] prams)
    {
        ///打开数据库连接
        Open();

        ///设置Command
        SqlCommand cmd = new SqlCommand(procName, myConnection);
        cmd.CommandType = CommandType.StoredProcedure;

        ///添加把存储过程的参数
        if (prams != null)
        {
            foreach (SqlParameter parameter in prams)
            {
                cmd.Parameters.Add(parameter);
            }
        }

        ///添加返回参数ReturnValue
        cmd.Parameters.Add(
            new SqlParameter(RETURNVALUE, SqlDbType.Int, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));

        ///返回创建的SqlCommand对象
        return cmd;
    }

    /// <summary>
    /// 创建一个SqlCommand对象以此来执行存储过程
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="prams">SQL语句所需参数</param>
    /// <returns>返回SqlCommand对象</returns>
    private SqlCommand CreateSQLCommand(string cmdText, SqlParameter[] prams)
    {
        ///打开数据库连接
        Open();

        ///设置Command
        SqlCommand cmd = new SqlCommand(cmdText, myConnection);

        ///添加把存储过程的参数
        if (prams != null)
        {
            foreach (SqlParameter parameter in prams)
            {
                cmd.Parameters.Add(parameter);
            }
        }

        ///添加返回参数ReturnValue
        cmd.Parameters.Add(
            new SqlParameter(RETURNVALUE, SqlDbType.Int, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));

        ///返回创建的SqlCommand对象
        return cmd;
    }

    /// <summary>
    /// 创建一个SqlDataAdapter对象，用此来执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <returns>返回SqlDataAdapter对象</returns>
    private SqlDataAdapter CreateProcDataAdapter(string procName, SqlParameter[] prams)
    {
        ///打开数据库连接
        Open();

        ///设置SqlDataAdapter对象
        SqlDataAdapter da = new SqlDataAdapter(procName, myConnection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        ///添加把存储过程的参数
        if (prams != null)
        {
            foreach (SqlParameter parameter in prams)
            {
                da.SelectCommand.Parameters.Add(parameter);
            }
        }

        ///添加返回参数ReturnValue
        da.SelectCommand.Parameters.Add(
            new SqlParameter(RETURNVALUE, SqlDbType.Int, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));

        ///返回创建的SqlDataAdapter对象
        return da;
    }

    /// <summary>
    /// 创建一个SqlDataAdapter对象，用此来执行SQL语句
    /// </summary>
    /// <param name="cmdText">SQL语句</param>
    /// <param name="prams">SQL语句所需参数</param>
    /// <returns>返回SqlDataAdapter对象</returns>
    private SqlDataAdapter CreateSQLDataAdapter(string cmdText, SqlParameter[] prams)
    {
        ///打开数据库连接
        Open();

        ///设置SqlDataAdapter对象
        SqlDataAdapter da = new SqlDataAdapter(cmdText, myConnection);

        ///添加把存储过程的参数
        if (prams != null)
        {
            foreach (SqlParameter parameter in prams)
            {
                da.SelectCommand.Parameters.Add(parameter);
            }
        }

        ///添加返回参数ReturnValue
        da.SelectCommand.Parameters.Add(
            new SqlParameter(RETURNVALUE, SqlDbType.Int, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));

        ///返回创建的SqlDataAdapter对象
        return da;
    }

    /// <summary>
    /// 创建一个SqlCommand对象以此来执行存储过程
    /// </summary>
    /// <param name="procName">存储过程的名称</param>
    /// <param name="prams">存储过程所需参数</param>
    /// <returns>返回SqlCommand对象</returns>
    private SqlCommand CreateCommand(string procName, SqlParameter[] prams)
    {
        /**/
        ///打开数据库连接
        Open();

        /**/
        ///设置Command
        SqlCommand cmd = new SqlCommand(procName, myConnection);
        cmd.CommandType = CommandType.StoredProcedure;

        /**/
        ///添加把存储过程的参数
        if (prams != null)
        {
            foreach (SqlParameter parameter in prams)
            {
                cmd.Parameters.Add(parameter);
            }
        }

        /**/
        ///添加返回参数ReturnValue
        cmd.Parameters.Add(
            new SqlParameter(RETURNVALUE, SqlDbType.Int, 4, ParameterDirection.ReturnValue,
            false, 0, 0, string.Empty, DataRowVersion.Default, null));

        /**/
        ///返回创建的SqlCommand对象
        return cmd;
    }

    /// <summary>
    /// 生成存储过程参数
    /// </summary>
    /// <param name="ParamName">存储过程名称</param>
    /// <param name="DbType">参数类型</param>
    /// <param name="Size">参数大小</param>
    /// <param name="Direction">参数方向</param>
    /// <param name="Value">参数值</param>
    /// <returns>新的 parameter 对象</returns>
    public SqlParameter CreateParam(string ParamName, SqlDbType DbType, Int32 Size, ParameterDirection Direction, object Value)
    {
        SqlParameter param;

        ///当参数大小为0时，不使用该参数大小值
        if (Size > 0)
        {
            param = new SqlParameter(ParamName, DbType, Size);
        }
        else
        {
            ///当参数大小为0时，不使用该参数大小值
            param = new SqlParameter(ParamName, DbType);
        }

        ///创建输出类型的参数
        param.Direction = Direction;
        if (!(Direction == ParameterDirection.Output && Value == null))
        {
            param.Value = Value;
        }

        ///返回创建的参数
        return param;
    }

    /// <summary>
    /// 传入输入参数
    /// </summary>
    /// <param name="ParamName">存储过程名称</param>
    /// <param name="DbType">参数类型</param></param>
    /// <param name="Size">参数大小</param>
    /// <param name="Value">参数值</param>
    /// <returns>新的parameter 对象</returns>
    public SqlParameter CreateInParam(string ParamName, SqlDbType DbType, int Size, object Value)
    {
        return CreateParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
    }

    /// <summary>
    /// 传入返回值参数
    /// </summary>
    /// <param name="ParamName">存储过程名称</param>
    /// <param name="DbType">参数类型</param>
    /// <param name="Size">参数大小</param>
    /// <returns>新的 parameter 对象</returns>
    public SqlParameter CreateOutParam(string ParamName, SqlDbType DbType, int Size)
    {
        return CreateParam(ParamName, DbType, Size, ParameterDirection.Output, null);
    }

    /// <summary>
    /// 传入返回值参数
    /// </summary>
    /// <param name="ParamName">存储过程名称</param>
    /// <param name="DbType">参数类型</param>
    /// <param name="Size">参数大小</param>
    /// <returns>新的 parameter 对象</returns>
    public SqlParameter CreateReturnParam(string ParamName, SqlDbType DbType, int Size)
    {
        return CreateParam(ParamName, DbType, Size, ParameterDirection.ReturnValue, null);
    }

    #region   执行参数命令文本(返回DataSet)
    /// <summary>
    /// 执行查询命令文本，并且返回DataSet数据集
    /// </summary>
    /// <param name="procName">命令文本</param>
    /// <param name="prams">参数对象</param>
    /// <param name="tbName">数据表名称</param>
    /// <returns></returns>
    public DataSet RunProcReturn(string procName, SqlParameter[] prams, string tbName)
    {
        SqlDataAdapter dap = CreateProcDataAdapter(procName, prams);
        DataSet ds = new DataSet();
        dap.Fill(ds, tbName);
        this.Close();
        //得到执行成功返回值
        return ds;
    }

    /// <summary>
    /// 执行命令文本，并且返回DataSet数据集
    /// </summary>
    /// <param name="procName">命令文本</param>
    /// <param name="tbName">数据表名称</param>
    /// <returns>DataSet</returns>
    public DataSet RunProcReturn(string procName, string tbName)
    {
        SqlDataAdapter dap = CreateProcDataAdapter(procName, null);
        DataSet ds = new DataSet();
        dap.Fill(ds, tbName);
        this.Close();
        //得到执行成功返回值
        return ds;
    }

    #endregion
}
