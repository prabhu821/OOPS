using System;
namespace OOPS.InventoryManagement
{
    class Program
    {
        static string InventoryFilePath = @"D:\BridgeLabz\OOPS\OOPS\OOPS\InventoryManagement\Inventory.json";
        static string InventoryDataFilePath = @"D:\BridgeLabz\OOPS\OOPS\OOPS\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(InventoryFilePath);

            //InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
            //inventoryDataManagement.ReadJsonFile(InventoryDataFilePath);
        }
    }
}