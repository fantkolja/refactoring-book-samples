abstract class Coffee
 {
   public virtual int Amount { get; set; }
   public virtual int Price { get; set; }
   abstract public double GetCalories();
 }


 class Americano : Coffee
 {
   public Americano() : base()
   {
     this.Amount = 100;
     this.Price = 25;
   }
   public override double GetCalories()
   {
     return this.Amount * 0.01;
   }
 }


 class Espresso : Coffee
 {
   public Espresso() : base()
   {
     this.Amount = 50;
     this.Price = 20;
   }
   public override double GetCalories()
   {
     return this.Amount * 0.03;
   }
 }
