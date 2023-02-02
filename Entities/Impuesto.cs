namespace Entities
{
    static class Impuesto
    {
        public static double IVA;
        public static double CalcularIVA21(double monto){
            IVA = monto*0.21;
            return IVA; 
        }
        public static double CalcularIVA10(double monto){
            IVA = monto*0.105;
            return IVA; 
        }
    }
}