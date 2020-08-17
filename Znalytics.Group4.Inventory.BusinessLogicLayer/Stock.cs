/// <summary>
/// created by hema
/// </summary>
public class StockBusinessLogicLayer
{
    Stock v = new Stock();
    /// <summary>
    /// Add method with 4 parameters 
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    /// <param name="ADD">Represents the no.of quantity u want to add</param>
    public void AddQuantity(int WHID, int AID, int PID, int ADD)
    {
        v.WareHouseID = WHID;
        v.AddressID = AID;
        v.ProductID = PID;
        v.Add = ADD;
    }
    /// <summary>
    /// Delete method with 4 parameters
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    /// <param name="SUB">Represents the no.of quamtities u want to delete</param>
    public void DeleteQuantity(int WHID, int AID, int PID, int SUB)
    {
        v.WareHouseID = WHID;
        v.AddressID = AID;
        v.ProductID = PID;
        v.Delete = SUB;
    }
    /// <summary>
    /// Update method with 3 parameters
    /// </summary>
    /// <param name="WHID">Represents WareHouseID</param>
    /// <param name="AID">Represents AddressID</param>
    /// <param name="PID">Represents ProductID</param>
    public void UpDateQuantity(int WHID, int AID, int PID)
    {

        v.WareHouseID = WHID;
        v.AddressID = AID;
        v.ProductID = PID;
    }
}