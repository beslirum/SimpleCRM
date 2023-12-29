// CustomerController.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class CustomerController
{
    private readonly DatabaseContext _context;

    public CustomerController(DatabaseContext context)
    {
        _context = context;
    }

    public void AddCustomer(Customer customer)
    {
        // Müşteri eklemeden önce e-posta benzersiz olmalıdır
        if (_context.Customers.Any(c => c.Email == customer.Email))
        {
            throw new InvalidOperationException("Bu e-posta adresi zaten kullanılmaktadır.");
        }

        _context.Customers.Add(customer);
        _context.SaveChanges();
    }

    public void UpdateCustomer(Customer updatedCustomer)
    {
        var existingCustomer = _context.Customers.Find(updatedCustomer.Id);

        if (existingCustomer != null)
        {
            // E-posta güncellenecekse, yeni e-postanın benzersiz olup olmadığını kontrol et
            if (existingCustomer.Email != updatedCustomer.Email &&
                _context.Customers.Any(c => c.Email == updatedCustomer.Email))
            {
                throw new InvalidOperationException("Bu e-posta adresi zaten kullanılmaktadır.");
            }

            // Diğer müşteri bilgilerini güncelle
            existingCustomer.FirstName = updatedCustomer.FirstName;
            existingCustomer.LastName = updatedCustomer.LastName;
            existingCustomer.Email = updatedCustomer.Email;
            existingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;

            _context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Belirtilen müşteri bulunamadı.");
        }
    }

    public void DeleteCustomer(int customerId)
    {
        var customerToDelete = _context.Customers.Find(customerId);

        if (customerToDelete != null)
        {
            _context.Customers.Remove(customerToDelete);
            _context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Belirtilen müşteri bulunamadı.");
        }
    }

    public List<Customer> GetAllCustomers()
    {
        return _context.Customers.ToList();
    }

    public Customer GetCustomerDetails(int customerId)
    {
        return _context.Customers.Find(customerId);
    }

    // Diğer müşteri işlemleri için metotlar eklenebilir.
}
