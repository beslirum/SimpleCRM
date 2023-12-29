// InteractionController.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class InteractionController
{
    private readonly DatabaseContext _context;

    public InteractionController(DatabaseContext context)
    {
        _context = context;
    }

    public void AddInteraction(Interaction interaction)
    {
        _context.Interactions.Add(interaction);
        _context.SaveChanges();
    }

    public void UpdateInteraction(Interaction updatedInteraction)
    {
        var existingInteraction = _context.Interactions.Find(updatedInteraction.Id);

        if (existingInteraction != null)
        {
            // Diğer etkileşim bilgilerini güncelle
            existingInteraction.InteractionDate = updatedInteraction.InteractionDate;
            existingInteraction.InteractionType = updatedInteraction.InteractionType;
            existingInteraction.Description = updatedInteraction.Description;

            _context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Belirtilen etkileşim bulunamadı.");
        }
    }

    public void DeleteInteraction(int interactionId)
    {
        var interactionToDelete = _context.Interactions.Find(interactionId);

        if (interactionToDelete != null)
        {
            _context.Interactions.Remove(interactionToDelete);
            _context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Belirtilen etkileşim bulunamadı.");
        }
    }

    public List<Interaction> GetAllInteractions()
    {
        return _context.Interactions.ToList();
    }

    public List<Interaction> GetCustomerInteractions(int customerId)
    {
        return _context.Interactions.Where(i => i.CustomerId == customerId).ToList();
    }

    // Diğer etkileşim işlemleri için metotlar eklenebilir.
}
