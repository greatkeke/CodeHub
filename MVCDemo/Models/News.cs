using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 新闻
    /// </summary>
    public class News
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid ID { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [StringLength(20,ErrorMessage="亲~标题过长就不醒目了~")]
        [Required]
        [DisplayName("标题")]
        public string Title { get; set; }
        /// <summary>
        /// 发表日期
        /// </summary>
        [DisplayName("发表日期")]
        public DateTime PortDate { get; set; }
        /// <summary>
        /// 作者编号
        /// </summary>
        [Required]
        [DisplayName("作者")]
        public Guid AutherId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("内容")]
        public string Content { get; set; }
    }
}
