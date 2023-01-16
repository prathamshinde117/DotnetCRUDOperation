namespace BLL;
using DAL;
using BOL;
public class HRManager
{
public static List<Department> GetAlldepartmentfromDal()
{
List<Department>list=new List<Department>();
list=DBmanager.GetallDepartments();
    return list;
}

public bool insert(int id,string name,string location)
{
    return DBmanager.Insert(id,name,location);
} 

// public bool Delete(int id,string name,string location)
// {
//     return DBmanager.Insert(id,name,location);
// } 

public void Deletedb(int id){
   
    DBmanager.Delete(id);
}

public void updatedb(int id,string name,string location){
   
    DBmanager.update(id,name,location);
}

}
