//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookAppSolution.BookService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookDto", Namespace="http://schemas.datacontract.org/2004/07/BookServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class BookDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RealeseYearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RealeseYear {
            get {
                return this.RealeseYearField;
            }
            set {
                if ((object.ReferenceEquals(this.RealeseYearField, value) != true)) {
                    this.RealeseYearField = value;
                    this.RaisePropertyChanged("RealeseYear");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookService.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        BookAppSolution.BookService.BookDto[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        System.Threading.Tasks.Task<BookAppSolution.BookService.BookDto[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookById", ReplyAction="http://tempuri.org/IBookService/DeleteBookByIdResponse")]
        void DeleteBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookById", ReplyAction="http://tempuri.org/IBookService/DeleteBookByIdResponse")]
        System.Threading.Tasks.Task DeleteBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/CreateNewBook", ReplyAction="http://tempuri.org/IBookService/CreateNewBookResponse")]
        int CreateNewBook(BookAppSolution.BookService.BookDto book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/CreateNewBook", ReplyAction="http://tempuri.org/IBookService/CreateNewBookResponse")]
        System.Threading.Tasks.Task<int> CreateNewBookAsync(BookAppSolution.BookService.BookDto book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        void UpdateBook(BookAppSolution.BookService.BookDto book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        System.Threading.Tasks.Task UpdateBookAsync(BookAppSolution.BookService.BookDto book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : BookAppSolution.BookService.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<BookAppSolution.BookService.IBookService>, BookAppSolution.BookService.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookAppSolution.BookService.BookDto[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<BookAppSolution.BookService.BookDto[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public void DeleteBookById(int id) {
            base.Channel.DeleteBookById(id);
        }
        
        public System.Threading.Tasks.Task DeleteBookByIdAsync(int id) {
            return base.Channel.DeleteBookByIdAsync(id);
        }
        
        public int CreateNewBook(BookAppSolution.BookService.BookDto book) {
            return base.Channel.CreateNewBook(book);
        }
        
        public System.Threading.Tasks.Task<int> CreateNewBookAsync(BookAppSolution.BookService.BookDto book) {
            return base.Channel.CreateNewBookAsync(book);
        }
        
        public void UpdateBook(BookAppSolution.BookService.BookDto book) {
            base.Channel.UpdateBook(book);
        }
        
        public System.Threading.Tasks.Task UpdateBookAsync(BookAppSolution.BookService.BookDto book) {
            return base.Channel.UpdateBookAsync(book);
        }
    }
}
