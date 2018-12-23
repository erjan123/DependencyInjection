namespace DemoLibrary.Interfaces
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}