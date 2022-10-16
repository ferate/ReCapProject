// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");


Console.WriteLine(" *** Merhaba Katmanlı Mimari Projesine Hoşgeldiniz ***");

CarManager carManager = new CarManager(new InMemoryCarDal());

Console.WriteLine("****************  Sisteme Kayıtlı Bütün Araçlar Listeleniyor **********************");

foreach (Car car in carManager.GetAll())
{
    Console.WriteLine("Araç ID:"+car.Id+", Araç Marka ID:"+car.BrandId + ", Araç Renk ID:" + car.ColorId + ", Araç Model Yılı:" + car.ModelYear + ", Araç Günlük Kiralama Bedeli" + car.DailyPrice + ", Açıklama:" + car.Description);
}


Console.WriteLine("************* Eklenen ve Silinen Kayıtlar Sonrası Sistemdeki Araçlar Listeleniyor ********************");

Car newCar = new Car() { Id=11, BrandId=9, ColorId=99, ModelYear=2023, DailyPrice=1453, Description="Son Eklenen Araç"};
carManager.Add(newCar);

Car deleteCar = new Car() { Id = 9 };
carManager.Delete(deleteCar);

foreach (Car car in carManager.GetAll())
{
    Console.WriteLine("Araç ID:" + car.Id + ", Araç Marka ID:" + car.BrandId + ", Araç Renk ID:" + car.ColorId + ", Araç Model Yılı:" + car.ModelYear + ", Araç Günlük Kiralama Bedeli" + car.DailyPrice + ", Açıklama:" + car.Description);
}

