using System;
using System.Configuration;
using CleaningServiceManagement.Models;

namespace CleaningServiceManagement.Services
{
    public static class PaymentService
    {
        private static readonly string ApiKey =
            ConfigurationManager.AppSettings["PaymentGatewayApiKey"];

        public static PaymentResult ProcessPayment(PaymentRequest request)
        {
            // Имитация интеграции с платежным шлюзом
            try
            {
                if (request.Amount <= 0)
                    throw new ArgumentException("Invalid amount");

                // Логика обработки платежа
                var isSuccess = new Random().Next(0, 100) > 20; // 80% успешных платежей

                return new PaymentResult
                {
                    IsSuccess = isSuccess,
                    TransactionId = isSuccess ? Guid.NewGuid().ToString() : null,
                    ErrorMessage = isSuccess ? null : "Payment declined by provider"
                };
            }
            catch (Exception ex)
            {
                return new PaymentResult
                {
                    IsSuccess = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public static string GenerateReceipt(PaymentResult payment)
        {
            return payment.IsSuccess
                ? $"Receipt #{payment.TransactionId}\nDate: {DateTime.Now:g}"
                : "Payment failed - no receipt";
        }
    }
}
