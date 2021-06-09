using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurents
{
    public class Resturant
    {
        private Database _database;
        public Resturant()
        {
            _database = new Database();
        }
        private List<ParamObj> CastObjToParams(ResturantObj resturantObj)
        {
            List<ParamObj> paramsObjList =  new List<ParamObj>()
                {
                    new ParamObj("Name", resturantObj.Name),
                    new ParamObj("RegionId",resturantObj.RegionId, ParamType.Int),
                    new ParamObj("Address", resturantObj.Address),
                    new ParamObj("Hotline", resturantObj.Hotline),
                };

            return paramsObjList;
        }
        public void Update(ResturantObj resturant)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {
                List<ParamObj> paramObjs = CastObjToParams(resturant);
                paramObjs.Add(new ParamObj("ID", resturant.Id, ParamType.Int));

                DataTable dt = _database.GetTable("ModifyRestaurent", paramObjs);
            };
        }

        public void Add(ResturantObj resturant)           
        {
            List<ResturantObj> resturantObjList = new List<ResturantObj>();

            using (var con = DataBaseConnection.SqlConnection)
            {

                List<ParamObj> paramObjs = CastObjToParams(resturant);
                DataTable dt = _database.GetTable("AddRestaurent", paramObjs);
            }
        }
        public void Delete(int id)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {

                List<ParamObj> paramObjs = new List<ParamObj>();
                ParamObj paramObj = new ParamObj() { Name = "Id", Value = id, Type = ParamType.Int };
                paramObjs.Add(paramObj);
                DataTable dt = _database.GetTable("DeleteRestaurent", paramObjs);


                
            }

        }
        public ResturantObj GetById(int id)
        {
            ResturantObj resturantObj = new ResturantObj();
            using (var con = DataBaseConnection.SqlConnection)
            {
                DataTable dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter("GetRestaurent", con))
                {

                    adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataTable);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    resturantObj.Id = int.Parse(row[0].ToString());
                    resturantObj.Name = row[1].ToString();
                    resturantObj.RegionId = int.Parse(row[2].ToString());
                    resturantObj.Address = row[3].ToString();
                    resturantObj.Hotline = row[4].ToString();
                }

                return resturantObj;
            }
        }
        public List<ResturantObj> GetByRegionId(int regionId)
        {
            List<ResturantObj> resturantObjList = new List<ResturantObj>();

            using (var con = DataBaseConnection.SqlConnection)
            {
                List<ParamObj> paramObjs = new List<ParamObj>();
                ParamObj paramObj = new ParamObj() { Name = "RegionId", Value = regionId, Type = ParamType.Int };
                paramObjs.Add(paramObj);
                DataTable dt = _database.GetTable("GetResturantByRegionId", paramObjs);

                foreach (DataRow row in dt.Rows)
                {
                    ResturantObj restaurent = new ResturantObj();
                    restaurent.Id = int.Parse(row[0].ToString());
                    restaurent.Name = row[1].ToString();
                    restaurent.RegionId = int.Parse(row[2].ToString());
                    restaurent.Address = row[3].ToString();
                    restaurent.Hotline = row[4].ToString();

                    resturantObjList.Add(restaurent);

                }
          
            };

            return resturantObjList;
        }
    }
}
