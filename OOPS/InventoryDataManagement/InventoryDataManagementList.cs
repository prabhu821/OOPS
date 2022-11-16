using Newtonsoft.Json;
using OOPS.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OOPS.InventoryDataManagement
{
    internal class InventoryDataManagementList
    {


        InventoryData inventories;
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            inventories = JsonConvert.DeserializeObject < InventoryData >(jsonData);
            RiceList = inventories.Rice;
            Display(RiceList);
            WheatList = inventories.Wheat;
            Display(WheatList);
            PulsesList = inventories.Pulses;
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        { 
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "\n" + data.Price + "\n" + data.Weight);
            }
        }
        public void AddInventoryDetails(string inventoryName)
        {
            Inventory inventory = new Inventory();
            if(inventoryName.Equals("Rice"))
            {
                inventory.Name = D;
                inventory.Price = 50.6;
                inventory.Weight = 10;
                RiceList.Add(inventory);
            }
        }
        public void WritToJsonFile(string filepath)
        {
            var json = JsonConvert.SerializeObject(inventories);
            File.WriteAllText(filepath, json);
        }
    }
    
}
