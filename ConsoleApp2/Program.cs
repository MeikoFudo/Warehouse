using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class ClothingItem //класс представляющий товар
        {
            public int ItemId { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            public int Quantity { get; set; }

            public ClothingItem(int itemId, string name, string size, int quantity)
            {
                ItemId = itemId; // id товара
                Name = name; // наименование
                Size = size; // размер одежды
                Quantity = quantity; //количество единиц товара
            }
        }

    // класс-склад одежды
    class ClothingWarehouse
    {
        private List<ClothingItem> items; // данные о товарах одежды

        public ClothingWarehouse()  // инициализируем склад
        {
            items = new List<ClothingItem>();
        }
        
        public void AddClothingItem(ClothingItem item) // добавление товара на склад
        {
            items.Add(item);
            Console.WriteLine("Товар добавлен на склад");
        }
        
        public void RemoveClothingItem(int itemId) // удаление товара со склада
        {
            items.RemoveAll(i => i.ItemId == itemId);
            Console.WriteLine("Товар удален со склада");
        }

        public void ListClothingItems() // вывод  информации о товаре
        {
            Console.WriteLine("ТОВАР НА СКЛАДЕ");
            Console.WriteLine("----------------");
            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.ItemId}, Наименование: {item.Name}, Размер: {item.Size}, Количество: {item.Quantity}");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            ClothingWarehouse warehouse = new ClothingWarehouse();  
            warehouse.AddClothingItem(new ClothingItem(1, "Футболка Я от тебя балдею", "M", 50));
            warehouse.AddClothingItem(new ClothingItem(2, "Платье Хулиганка", "S", 20));
            warehouse.ListClothingItems();
            warehouse.RemoveClothingItem(1);
            warehouse.ListClothingItems();
        }
    }
}

