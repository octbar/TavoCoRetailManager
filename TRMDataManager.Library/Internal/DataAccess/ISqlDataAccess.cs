﻿using System.Collections.Generic;

namespace TRMDataManager.Library.Internal.DataAccess
{
    public interface ISqlDataAccess
    {
        void Committransaction();
        void Dispose();
        List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters);
        void RollbackTransaction();
        void SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
        void SaveDataInTransaction<T>(string storedProcedure, T parameters);
        void StartTransaction(string connectionStringName);
    }
}