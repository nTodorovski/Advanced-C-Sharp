using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public string FavoriteFoodName { get; set; }

        public Dog(string name,int age,string ownerName,bool isGoodBoi,string favoriteFood):base(name,age,ownerName)
        {
            IsGoodBoi = isGoodBoi;
            FavoriteFoodName = favoriteFood;
            Type = Tip.Dog;
        }

        public override void PrintPet()
        {
            Console.WriteLine($"Name: {Name} \nAge: {Age} \nOwnerName: {OwnerName} \nType: {Type} \nFavorite Food: {FavoriteFoodName} \n Is Good Boi: {IsGoodBoi}");
        }
    }
}