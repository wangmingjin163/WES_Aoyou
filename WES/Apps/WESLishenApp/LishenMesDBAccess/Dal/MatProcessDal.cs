﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LishenMesDBAccess.DBUtility;//Please add references
namespace LishenMesDBAccess.DAL
{
    /// <summary>
    /// 数据访问类:MatProcessModel
    /// </summary>
    public partial class MatProcessDal
    {
        public MatProcessDal()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ShopName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MatProcess");
            strSql.Append(" where ShopName='" + ShopName + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(LishenMesDBAccess.Model.MatProcessModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ShopName != null)
            {
                strSql1.Append("ShopName,");
                strSql2.Append("'" + model.ShopName + "',");
            }
            if (model.ZhengjiHongkao != null)
            {
                strSql1.Append("ZhengjiHongkao,");
                strSql2.Append("" + model.ZhengjiHongkao + ",");
            }
            if (model.FujiHongkao != null)
            {
                strSql1.Append("FujiHongkao,");
                strSql2.Append("" + model.FujiHongkao + ",");
            }
            if (model.GemoHongkao != null)
            {
                strSql1.Append("GemoHongkao,");
                strSql2.Append("" + model.GemoHongkao + ",");
            }
            if (model.tag1 != null)
            {
                strSql1.Append("tag1,");
                strSql2.Append("'" + model.tag1 + "',");
            }
            if (model.tag2 != null)
            {
                strSql1.Append("tag2,");
                strSql2.Append("'" + model.tag2 + "',");
            }
            if (model.tag3 != null)
            {
                strSql1.Append("tag3,");
                strSql2.Append("'" + model.tag3 + "',");
            }
            if (model.tag4 != null)
            {
                strSql1.Append("tag4,");
                strSql2.Append("'" + model.tag4 + "',");
            }
            if (model.tag5 != null)
            {
                strSql1.Append("tag5,");
                strSql2.Append("'" + model.tag5 + "',");
            }
            if (model.mark != null)
            {
                strSql1.Append("mark,");
                strSql2.Append("'" + model.mark + "',");
            }
            strSql.Append("insert into MatProcess(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(LishenMesDBAccess.Model.MatProcessModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MatProcess set ");
            if (model.ZhengjiHongkao != null)
            {
                strSql.Append("ZhengjiHongkao=" + model.ZhengjiHongkao + ",");
            }
            if (model.FujiHongkao != null)
            {
                strSql.Append("FujiHongkao=" + model.FujiHongkao + ",");
            }
            if (model.GemoHongkao != null)
            {
                strSql.Append("GemoHongkao=" + model.GemoHongkao + ",");
            }
            if (model.tag1 != null)
            {
                strSql.Append("tag1='" + model.tag1 + "',");
            }
            else
            {
                strSql.Append("tag1= null ,");
            }
            if (model.tag2 != null)
            {
                strSql.Append("tag2='" + model.tag2 + "',");
            }
            else
            {
                strSql.Append("tag2= null ,");
            }
            if (model.tag3 != null)
            {
                strSql.Append("tag3='" + model.tag3 + "',");
            }
            else
            {
                strSql.Append("tag3= null ,");
            }
            if (model.tag4 != null)
            {
                strSql.Append("tag4='" + model.tag4 + "',");
            }
            else
            {
                strSql.Append("tag4= null ,");
            }
            if (model.tag5 != null)
            {
                strSql.Append("tag5='" + model.tag5 + "',");
            }
            else
            {
                strSql.Append("tag5= null ,");
            }
            if (model.mark != null)
            {
                strSql.Append("mark='" + model.mark + "',");
            }
            else
            {
                strSql.Append("mark= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ShopName='" + model.ShopName + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ShopName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MatProcess ");
            strSql.Append(" where ShopName='" + ShopName + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public LishenMesDBAccess.Model.MatProcessModel GetModel(string ShopName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ShopName,ZhengjiHongkao,FujiHongkao,GemoHongkao,tag1,tag2,tag3,tag4,tag5,mark ");
            strSql.Append(" from MatProcess ");
            strSql.Append(" where ShopName='" + ShopName + "' ");
            LishenMesDBAccess.Model.MatProcessModel model = new LishenMesDBAccess.Model.MatProcessModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public LishenMesDBAccess.Model.MatProcessModel DataRowToModel(DataRow row)
        {
            LishenMesDBAccess.Model.MatProcessModel model = new LishenMesDBAccess.Model.MatProcessModel();
            if (row != null)
            {
                if (row["ShopName"] != null)
                {
                    model.ShopName = row["ShopName"].ToString();
                }
                if (row["ZhengjiHongkao"] != null && row["ZhengjiHongkao"].ToString() != "")
                {
                    model.ZhengjiHongkao = int.Parse(row["ZhengjiHongkao"].ToString());
                }
                if (row["FujiHongkao"] != null && row["FujiHongkao"].ToString() != "")
                {
                    model.FujiHongkao = int.Parse(row["FujiHongkao"].ToString());
                }
                if (row["GemoHongkao"] != null && row["GemoHongkao"].ToString() != "")
                {
                    model.GemoHongkao = int.Parse(row["GemoHongkao"].ToString());
                }
                if (row["tag1"] != null)
                {
                    model.tag1 = row["tag1"].ToString();
                }
                if (row["tag2"] != null)
                {
                    model.tag2 = row["tag2"].ToString();
                }
                if (row["tag3"] != null)
                {
                    model.tag3 = row["tag3"].ToString();
                }
                if (row["tag4"] != null)
                {
                    model.tag4 = row["tag4"].ToString();
                }
                if (row["tag5"] != null)
                {
                    model.tag5 = row["tag5"].ToString();
                }
                if (row["mark"] != null)
                {
                    model.mark = row["mark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ShopName,ZhengjiHongkao,FujiHongkao,GemoHongkao,tag1,tag2,tag3,tag4,tag5,mark ");
            strSql.Append(" FROM MatProcess ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ShopName,ZhengjiHongkao,FujiHongkao,GemoHongkao,tag1,tag2,tag3,tag4,tag5,mark ");
            strSql.Append(" FROM MatProcess ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM MatProcess ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ShopName desc");
            }
            strSql.Append(")AS Row, T.*  from MatProcess T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
        #region  MethodEx

        #endregion  MethodEx
    }
}
