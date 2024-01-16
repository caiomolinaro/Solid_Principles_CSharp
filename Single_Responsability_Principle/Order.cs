namespace Single_Responsability_Principle;

internal class Order
{
    public long Quantity { get; set; }
    public DateTime Date { get; set; }

    private RegisterLog logger;
    private SendEmail sendEmail;

    public Order()
    {
        sendEmail = new SendEmail();
        logger = new RegisterLog();
    }

    public void IncludeOrder()
    {
        try
        {
            logger.Info("Include a order");

            sendEmail.EmailFrom = "abc@abc.com";
            sendEmail.EmailTo = "xyz@xyz.com";
            sendEmail.EmailSubject = "SRP";
            sendEmail.EmailBody = "SOLID Principle";
            sendEmail.Send();
        }
        catch (Exception ex)
        {
            logger.Info("Error to send a email : " + ex.Message);
        }
    }

    public void DeleteOrder()
    {
        try
        {
            logger.Info("Order deleted " + DateTime.Now);
        }
        catch (Exception ex)
        {
            logger.Info("Error to delete a order " + ex.Message);
        }
    }
}