﻿using MenShopBlazor.DTOs.Order.OrderReponse;
using MenShopBlazor.DTOs.Payment;
using MenShopBlazor.DTOs.VNPay;

namespace MenShopBlazor.Services.Payment
{
    public interface IPaymentService
    {
        Task<PaymentViewModel?> GetPaymentByOrderIdAsync(string orderId);
        Task<PaymentViewModel?> GetPaymentByPaymentIdAsync(string paymentId);
        Task<string> CreateVNPayUrlAsync(VnPaymentRequestModel model);
        Task<PaymentResponseDTO> AddPaymentToOrderAsync(string orderId, CreatePaymentDTO dto);
        Task<VnPaymentResponseModel> HandleVNPayCallbackAsync(string queryString);
    }
}
