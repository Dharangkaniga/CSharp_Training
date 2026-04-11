namespace TicketCalculator
{
    public class ConcessionCalculator
    {
        public string CalculateConcession(int age, double totalFare)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double finalFare = totalFare - (totalFare * 0.30);
                return "Senior Citizen - Fare: " + finalFare;
            }
            else
            {
                return "Ticket Booked - Fare: " + totalFare;
            }
        }
    }
}