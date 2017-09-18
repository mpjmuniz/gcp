using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;



namespace Ptc.iESF.OfflineServices.DetectEmptyCategories.DataAccess
{
    public class EntityGateway
    {
        #region Instance variables.
        private int maxRetries;

        private iESF_CatalogCategoriesToRemove entitiesSet;
        private EntityConnection entConnection;
        #endregion


        #region Ctors.
        public EntityGateway(string dbServer, string dbDatabase, int maxRetries)
        {
            this.maxRetries = maxRetries;
            this.entConnection = this.GetConnection(dbServer, dbDatabase);
            this.entitiesSet = new iESF_CatalogCategoriesToRemove(this.entConnection);
        }
        #endregion


        #region Private Methods.
        private EntityConnection GetConnection(string dbServer, string dbDatabase)
        {
            EntityConnection conn = null;


            //Builds the connection string.
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = dbServer;
            sqlBuilder.InitialCatalog = dbDatabase;
            sqlBuilder.IntegratedSecurity = true;


            //Builds the entity model connection string.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;
            entityBuilder.Metadata = @"res://*/DataAccess.CatalogCategoriesToRemove.csdl|res://*/DataAccess.CatalogCategoriesToRemove.ssdl|res://*/DataAccess.CatalogCategoriesToRemove.msl";


            //Builds the connection instance.
            conn = new EntityConnection(entityBuilder.ToString());

            return conn;
        }
        #endregion


        #region Public Methods.
        public void Open()
        {
            this.entConnection.Open();
        }

        public void Close()
        {
            this.entConnection.Close();
            this.entConnection.Dispose();
        }

        public void AddCatalogCategoryToBeRemoved(string catgName, string catDispName, string catlName) {
            entitiesSet.sp_InsertCategoriesToBeRemoved(catgName, catDispName, catlName);

            entitiesSet.SaveChanges();
        }

        #endregion
    }
}