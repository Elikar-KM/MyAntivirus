using System.ServiceModel;

namespace AntiLib
{
    [ServiceContract]
    public interface IMCF
    {
        //сканирование
        [OperationContract]
        bool GetStatus();
        [OperationContract]
        float GetProgress();
        [OperationContract]
        bool StartScaning(string path, DateValue.Operation oper);
        [OperationContract]
        bool StopScaning();
        [OperationContract]
        void StartTimer();
        //Мониторинг
        [OperationContract]
        void DestroyObserver(string path);
        [OperationContract]
        bool CreateObserver(string path,DateValue.Operation oper);
        //Операции
        [OperationContract]
        void MoveBackQuarantine(string path);
        [OperationContract]
        void DeleteFile(string path);
        [OperationContract]
        void ReloadObserver();
        //БД
        [OperationContract]
        string[] GetQuarantine();
        [OperationContract]
        void DeleteQuarantine(string path);
        [OperationContract]
        string[] GetObserver();
        [OperationContract]
        string[] GetTime();
        [OperationContract]
        void DeleteTime(string time,string path);
        [OperationContract]
        bool AddTime(string time, string path, DateValue.Operation oper);
        [OperationContract]
        string[] GetReport();
        [OperationContract]
        string[] GetFile(int idReport);

    }
}

