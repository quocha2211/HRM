using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("BangTamUng")]
    public class SalaryAdvance
    {
        [Key]
        public int MaBTU { get; set; }  // Primary Key, auto-incremented
        public DateTime NgayTU { get; set; }  // Date of advance payment
        public int Thang { get; set; }  // Month
        public int Nam { get; set; }  // Year
        public double SoTienTU { get; set; }  // Amount of the advance
        public string DienGiai { get; set; }  // Description or reason for advance (nullable)

        // Foreign key to NhanVien (Employee)
        public int? MaNV { get; set; }  // Employee ID (nullable)

    }
}
