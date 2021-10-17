using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;
using BusinessObject.DBContext;

namespace DataAccess.DAO
{
    public class CakeDAO
    {
        private static CakeDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CakeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CakeDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Cake> GetCakeList(bool status)
        {
            var cakes = new List<Cake>();
            try
            {
                using var context = new CakeManagementContext();
                cakes = context.Cakes.ToList().FindAll(cake => cake.Status == status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cakes;
        }

        public Cake GetCakeByID (int CakeID)
        {
            Cake cake = null;
            try
            {
                using var context = new CakeManagementContext();
                cake = context.Cakes.SingleOrDefault(c => c.Cakeid == CakeID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cake;
        }

        public void AddNew (Cake cake)
        {
            try
            {
                using var context = new CakeManagementContext();
                var tmp = context.Cakes.ToList().Find(c => c.Cakename == cake.Cakename);
                if (tmp != null)
                {
                    throw new Exception("Cake name already been used");
                }
                else
                {
                    context.Cakes.Add(cake);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Inactivate (int cakeID)
        {
            try
            {
                Cake cake = GetCakeByID(cakeID);
                if (cake != null)
                {
                    if (cake.Status == true)
                    {
                        cake.Status = false;
                        using var context = new CakeManagementContext();
                        context.Cakes.Update(cake);
                        context.SaveChanges();
                    } else
                    {
                        throw new Exception("This cake is already inactive");
                    }
                } else
                {
                    throw new Exception("This cake doesn't exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Activate(int cakeID)
        {
            try
            {
                Cake cake = GetCakeByID(cakeID);
                if (cake != null)
                {
                    if (cake.Status == false)
                    {
                        cake.Status = true;
                        using var context = new CakeManagementContext();
                        context.Cakes.Update(cake);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This cake is already active");
                    }
                }
                else
                {
                    throw new Exception("This cake doesn't exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Cake cake)
        {
            try
            {
                Cake exist = GetCakeByID(cake.Cakeid);
                if (exist != null)
                {
                    using var context = new CakeManagementContext();
                    context.Cakes.Update(cake);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This cake doesn't exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Cake> SearchCake(string IDValue, string NameValue, bool status)
        {
            //List<Cake> cakes = new List<Cake>();
            var cakes = new List<Cake>();
            try
            {
                using var context = new CakeManagementContext();
                /*List<Cake> tmp = context.Cakes.ToList();
                foreach(Cake cake in tmp)
                {
                    if (cake.Status == status)
                    {
                        if (cake.Cakeid.ToString() == IDValue && cake.Cakename.Contains(NameValue) && !NameValue.Equals(""))
                        {
                            cakes.Add(cake);
                        } else if (cake.Cakename.Contains(NameValue) && !NameValue.Equals(""))
                        {
                            cakes.Add(cake);
                        } else if (cake.Cakeid.ToString() == IDValue)
                        {
                            cakes.Add(cake);
                        }
                    }
                }*/

                if (IDValue != "" && NameValue != "")
                {
                    cakes = context.Cakes.ToList().FindAll
                        (c => c.Cakeid == int.Parse(IDValue) && c.Cakename.Contains(NameValue));
                }
                else if (NameValue != "")
                {
                    cakes = context.Cakes.ToList().FindAll
                        (c => c.Cakename.Contains(NameValue));
                }
                else if (IDValue != "")
                {
                    cakes = context.Cakes.ToList().FindAll
                        (c => c.Cakeid == int.Parse(IDValue));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cakes;
        }
    }
}
