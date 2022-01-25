namespace Module_17_Patterns
{
    /// <summary>
    /// Получатель уведомлений
    /// </summary>
    public class Receiver
    {
        public Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
        {
            this.EmailNotification = emailNotification;
            this.SmsNotification = smsNotification;
            this.VoiceNotification = voiceNotification;
        }

        //банковские переводы
        public bool EmailNotification { get; set; }
        //денежные переводы-WesternUnion, Unistream
        public bool SmsNotification { get; set; }
        //переводы через PayPal
        public bool VoiceNotification { get; set; }
    }
}