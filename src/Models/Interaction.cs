// Interaction.cs

using System;

public class Interaction
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime InteractionDate { get; set; }
    public string InteractionType { get; set; }
    public string Description { get; set; }

    // Diğer etkileşim bilgilerini eklemek için özellikler eklenebilir

    // Navigation Property: Etkileşimin ait olduğu müşteri
    public Customer Customer { get; set; }
}
