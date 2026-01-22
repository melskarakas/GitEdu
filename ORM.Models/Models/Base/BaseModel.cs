using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
    public class BaseModel
    {
        /// <summary>
        /// ilgili kaydı kimin oluştuğunu kaydeder. Değer gönderilmezse '00000000-0000-0000-0000-000000000000' verir.
        /// </summary>
        public Guid created_by { get; set; }
        /// <summary>
        /// ilgili kaydı kimin değiştirdiğini/güncellediğini kaydeder. Değer gönderilmezse '00000000-0000-0000-0000-000000000000' verir.
        /// </summary>
        public Guid modified_by { get; set; }
        /// <summary>
        /// ilgili kaydın ne zaman oluştuğunu kaydeder. Değer gönderilmezse anlık tarihi verir.
        /// </summary>
        public DateTime created_date { get; set; } = DateTime.Now;

        /// <summary>
        /// ilgili kaydın en son ne zaman güncellendiğini kaydeder. Değer gönderilmezse anlık tarihi verir.
        /// </summary>
        public DateTime modified_date { get; set; } = DateTime.Now;

        /// <summary>
        /// ilgili kaydın akfitf veya pasif olduğunu belirtir.
        /// </summary>
        public bool is_active { get; set; } = true;

        /// <summary>
        /// Silinmiş ise true değer verilir.
        /// </summary>
        public bool is_deleted { get; set; } = false;
    }
}
