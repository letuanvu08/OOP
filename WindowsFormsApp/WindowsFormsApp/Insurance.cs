namespace WindowsFormsApp
{
    class Insurance
    {
        public int InsuranceId { get; set; }

        public TypeInsurance Type { get; set; }
        public Insurance() { }
        public Insurance( TypeInsurance type)
        {
            this.Type = type;
           
        }
        public Insurance(int id, TypeInsurance type)
        {
            this.Type = type;
            this.InsuranceId = id;
        }

    }
}
