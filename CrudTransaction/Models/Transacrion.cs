using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudTransaction.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options) { }
        public DbSet<Transaction> Transactions { get; set; } = null!;
    }
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Номер рахунку")]
        [Required(ErrorMessage ="Це поле обов'язкове")]
        [MaxLength(12,ErrorMessage ="Максимум 12")]
        public string AccountNumber { get; set; } = null!;

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Номер отримувача")]
        [Required(ErrorMessage = "Це поле обов'язкове")]
        public string BeneficiaryName { get; set; } = null!;

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Номер банку")]
        [Required(ErrorMessage = "Це поле обов'язкове")]
        public string BankName { get; set; } = null!;

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Номер свіфт коду")]
        [Required(ErrorMessage = "Це поле обов'язкове")]
        [MaxLength(11, ErrorMessage = "Максимум 11")]
        public string SWIFTCode { get; set; } = null!;
        [Range(0, 5000, ErrorMessage = "Перевища допустима сума")]
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }

    }
}
