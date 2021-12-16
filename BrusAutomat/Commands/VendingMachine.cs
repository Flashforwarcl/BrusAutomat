using InputHandler;

namespace BrusAutomat.Commands
{
    public class VendingMachine : ICommands
    {
        public string Run()
        { 
            var vendingMachine = new Storage.StorageUnit.Unit(53, 20, 1);
            return  vendingMachine.ShowAllItemsAsGrid();
        }
    }
}