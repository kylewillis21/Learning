namespace BethanyPieShopHRM.HR
{
    struct WorkTask
    {
        public string description;
        public int hours;

        public void PerfromWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed.");
        }
    }
}
