﻿namespace MagicVanilla_CouponAPI.Models.DTO
{
    public class CouponDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PercentOff { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Created { get; set; }
    }
}
