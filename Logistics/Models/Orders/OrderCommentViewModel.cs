using System;

namespace Logistics.Models.Orders
{
    public class OrderCommentViewModel
    {
        public DateTime CreateDate { get; set; }
        public string PersonName { get; set; }
        public string Comment { get; set; }
        public string CommentDate => CreateDate.Date.ToString("d");
        public string CommentTime => CreateDate.ToString("t");
        public OrderCommentViewModel(string PersonName  , DateTime CreateDate)
        {
            this.PersonName = PersonName;
            this.CreateDate = CreateDate;
            this.Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        }
        public OrderCommentViewModel(string PersonName, DateTime CreateDate,string Comment)
        {
            this.PersonName = PersonName;
            this.CreateDate = CreateDate;
            this.Comment = Comment;
        }
    }
}