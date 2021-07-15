
namespace Polimorfismo_ex1.Entities
{
    class OutsouceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsouceEmployee(string name, int hours, double valuePerHour ,double additionalCharge)
        : base(name,hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }   
}
