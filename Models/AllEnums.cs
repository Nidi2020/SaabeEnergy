using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AllEnums
{
    public class Module//نام ماژولها بایستی تماما حروف کوچک باشد.
    {
        public enum MainModule
        {
            generalcase = 1, cmspage = 2, statecity = 3, banner = 4, poll = 5, faqgroup = 6, faq = 7, catalog = 8, newsletter = 9, service = 10, socialnetwork = 11,
            contactus = 12, support = 13, customer = 14, instagram = 15,

            newsmanager = 16, newsgroup = 17, news = 18, searchkeyword = 19,

            dynamicformmanager = 20, contact = 21, formpriceinquiry = 22, question = 23, formpricerequest = 24, career = 25, comment = 26,

            productmanager = 27, productgroup = 28, productgroupproperty = 29, brand = 30, product = 31,


            usermanager = 32, userinfo = 33, message = 34,

            orders = 35, paymentmethod = 36, sendmethod = 37, /*post = 38,*/ userorder = 39,

            sitesetting = 40, changepass = 41, adminleveltwo = 42, updatesitemap = 43,
            //module = 44,
            usermodule = 45,
            userchangepass = 46, userchangename = 47,  
            userchangepassadmin = 49,

            smssetting=50,


        };

        //last id 48
        public static string MainModulePersianName(MainModule mainModule)
        {
            string retVal = string.Empty;
            switch (mainModule)
            {
                case MainModule.generalcase:
                    retVal = " موارد کلی سایت";
                    break;
                case MainModule.cmspage:
                    retVal = "مدیریت محتوا";
                    break;
                case MainModule.statecity:
                    retVal = "مدیریت شهر و استان ";
                    break;
                case MainModule.banner:
                    retVal = "مدیریت بنرها";
                    break;
                case MainModule.poll:
                    retVal = "مدیریت نظرسنجی";
                    break;
                case MainModule.faqgroup:
                    retVal = "مدیریت گروه سوالات متداول";
                    break;
                case MainModule.faq:
                    retVal = "مدیریت سوالات متدوال";
                    break;
                case MainModule.catalog:
                    retVal = "مدیریت کاتالوگ";
                    break;
                case MainModule.newsletter:
                    retVal = "مدیریت اعضاء خبرنامه";
                    break;
                case MainModule.socialnetwork:
                    retVal = "مدیریت شبکه های اجتماعی";
                    break;
                case MainModule.service:
                    retVal = "مدیریت خدمات";
                    break;
                case MainModule.contactus:
                    retVal = "اطلاعات تماس";
                    break;
                case MainModule.support:
                    retVal = "مدیریت پشتیبانی";
                    break;
                case MainModule.customer:
                    retVal = "مدیریت مشتریان";
                    break;
                case MainModule.instagram:
                    retVal = "مدیریت تازه های اینستاگرام";
                    break;
                case MainModule.newsmanager:
                    retVal = "اخبار";
                    break;
                case MainModule.newsgroup:
                    retVal = "مدیریت گروه اخبار";
                    break;
                case MainModule.news:
                    retVal = "مدیریت اخبار";
                    break;
                case MainModule.searchkeyword:
                    retVal = "مدیریت هشتک های داغ خبر";
                    break;

                //case MainModule.articlemanager:
                //    retVal = " مقالات";
                //    break;
                //case MainModule.articlegroup:
                //    retVal = "مدیریت گروه  مقالات";
                //    break;
                //case MainModule.article:
                //    retVal = "مدیریت  مقالات";
                //    break;
                //case MainModule.gallery:
                //    retVal = "گالری";
                //    break;
                //case MainModule.picturegallerygroup:
                //    retVal = "مدیریت آلبوم های گالری تصاویر";
                //    break;
                //case MainModule.picturegallery:
                //    retVal = "مدیریت گالری تصاویر";
                //    break;
                //case MainModule.videogallerygroup:
                //    retVal = "مدیریت آلبوم های گالری ویدیو";
                //    break;
                //case MainModule.videogallery:
                //    retVal = "مدیریت گالری ویدیو";
                //    break;
                case MainModule.dynamicformmanager:
                    retVal = "فرم ها";
                    break;
                //case MainModule.dynamicform:
                //    retVal = "مدیریت فرم های داینامیک";
                //    break;
                case MainModule.contact:
                    retVal = "مدیریت فرم های تماس با ما";
                    break;
                case MainModule.formpriceinquiry:
                    retVal = "مدیریت فرم های درخواست سریع استعلام قیمت";
                    break;
                case MainModule.question:
                    retVal = "مدیریت سوالات فرم اعلام قیمت";
                    break;
                case MainModule.formpricerequest:
                    retVal = "مدیریت فرم های درخواست اعلام قیمت";
                    break;
                case MainModule.career:
                    retVal = "مدیریت فرم های همکاری با ما";
                    break;
                case MainModule.comment:
                    retVal = "مدیریت نظرات کاربران";
                    break;

                //case MainModule.dynamicfieldmanager:
                //    retVal = "فیلدها";
                //    break;
                //case MainModule.dynamicfieldgroup:
                //    retVal = "مدیریت دسته بندی فیلدها";
                //    break;
                //case MainModule.productgroupdynamicfield:
                //    retVal = "مدیریت فیلدها";
                //    break;

                case MainModule.productmanager:
                    retVal = "محصولات";
                    break;
                case MainModule.productgroup:
                    retVal = "مدیریت گروه محصولات";
                    break;
                case MainModule.productgroupproperty:
                    retVal = "مدیریت تعریف مشخصات";
                    break;
                case MainModule.brand:
                    retVal = "مدیریت تامین کنندگان";
                    break;
                case MainModule.product:
                    retVal = "مدیریت محصولات";
                    break;
                case MainModule.usermanager:
                    retVal = "اعضای سایت";
                    break;
                case MainModule.userinfo:
                    retVal = "مدیریت اعضای سایت";
                    break;
                case MainModule.message:
                    retVal = "ارسال پیام به اعضا";
                    break;
                case MainModule.orders:
                    retVal = "سفارشات";
                    break;
                case MainModule.paymentmethod:
                    retVal = "مدیریت روشهای پرداخت";
                    break;
                case MainModule.sendmethod:
                    retVal = "مدیریت روشهای ارسال";
                    break;
                //case MainModule.post:
                //    retVal = "مدیریت هزینه های پست";
                //    break;
                case MainModule.userorder:
                    retVal = "مدیریت سفارشات";
                    break;
                case MainModule.sitesetting:
                    retVal = "مدیریت تنظیمات سایت";
                    break;
                case MainModule.changepass:
                    retVal = "تغییر کلمه عبور";
                    break;
                case MainModule.adminleveltwo:
                    retVal = "سایر مدیران پنل";
                    break;
                case MainModule.userchangepass:
                    retVal = "تغییر کلمه عبور کاربران";
                    break;
                case MainModule.userchangename:
                    retVal = "تغییر نام کاربری کاربران";
                    break;
                case MainModule.usermodule:
                    retVal = " دسترسی کاربر";
                    break;
                //case MainModule.module:
                //    retVal = "ماژول ها";
                //    break;
                case MainModule.updatesitemap:
                    retVal = "بروز رسانی نقشه سایت";
                    break;
                case MainModule.userchangepassadmin:
                    retVal = "تغییر کلمه عبور مدیران";
                    break;
                case MainModule.smssetting:
                    retVal = "تنظیمات پنل اس ام اس";
                    break;
                default:
                    break;

            }

            return retVal;
        }

        public enum SubModule { };
        public static string SubModulePersianName(SubModule subModule)
        {
            string retVal = string.Empty;
            return retVal;

        }
    }
    public class Gallery
    {
        public enum ObjectType { News = 1, Article = 2 }

        public static string ObjectTypePersianName(ObjectType objectType)
        {
            string retVal = string.Empty;
            switch (objectType)
            {
                case ObjectType.News:
                    retVal = "اخبار";
                    break;
                case ObjectType.Article:
                    retVal = "مقالات";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }
    public class AlertStock
    {
        public enum Type { Promotion = 1, Stock = 2 };

        public static string TypePersianName(Type type)
        {
            string retVal = string.Empty;
            switch (type)
            {
                case Type.Promotion:
                    retVal = "تخفیف";
                    break;
                case Type.Stock:
                    retVal = "موجودی";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum StatusType { Email = 1, Sms = 2, Inbox = 3 };

        public static string StatusTypePersianName(StatusType statusType)
        {
            string retVal = string.Empty;
            switch (statusType)
            {
                case StatusType.Email:
                    retVal = "ایمیل";
                    break;
                case StatusType.Sms:
                    retVal = "پیامک";
                    break;
                case StatusType.Inbox:
                    retVal = "صندوق پیام";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum Kind { AlertStock = 1, AlertFavorit = 2 };

        public static string KindPersianName(Kind kind)
        {
            string retVal = string.Empty;
            switch (kind)
            {
                case Kind.AlertStock:
                    retVal = "خبرم کن";
                    break;
                case Kind.AlertFavorit:
                    retVal = "لیست آروزها";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Banner
    {
        public enum FileType { Pic = 1, Flash = 2 };

        public static string FileTypePersianName(FileType fileType)
        {
            string retVal = string.Empty;
            switch (fileType)
            {
                case FileType.Pic:
                    retVal = "عکس";
                    break;
                case FileType.Flash:
                    retVal = "فلش";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum PageType { Current = 1, NewPage = 2, Site = 3 };

        public static string PageTypePersianName(PageType pageType)
        {
            string retVal = string.Empty;
            switch (pageType)
            {
                case PageType.Current:
                    retVal = "صفحه جاری";
                    break;
                case PageType.NewPage:
                    retVal = "صفحه جدید";
                    break;
                case PageType.Site:
                    retVal = "وب سایت";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum Position
        {
            MainPage = 1, Banner = 2,
            //ProductCenter = 3,
            Product = 4,
            News = 5, NewsDetail = 6, NewsBanner = 7,
            Supplier = 8, SupplierDetail = 10,
            WeightTable = 11, ArchiveTable = 12,
            PriceList = 13, PriceList_Pic = 14, PriceList_Header = 15,


        };

        public static string PositionPersianName(Position position)
        {
            string retVal = string.Empty;
            switch (position)
            {
                case Position.MainPage:
                    retVal = "اسلایدر صفحه اصلی - سایز 370*785 پیکسل";
                    break;
                case Position.Banner:
                    retVal = "تصویر بنر تبلیغاتی صفحه اصلی - سایز 200*490 پیکسل";
                    break;
                //case Position.ProductCenter:
                //    retVal = "تصویر بنر تبلیغاتی وسط صفحه محصول - سایز 275*1200 پیکسل";
                //    break;
                case Position.Product:
                    retVal = "تصویر بنر تبلیغاتی پایین صفحه جزییات محصول - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.News:
                    retVal = "تصویر بنر تبلیغاتی صفحه اخبار - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.NewsDetail:
                    retVal = "تصویر بنر تبلیغاتی صفحه جزییات خبر - سایز 154*405 پیکسل";
                    break;
                case Position.NewsBanner:
                    retVal = "تصویر بالای صفحه اخبار - سایز بزرگ 317*1583 پیکسل";
                    break;
                case Position.Supplier:
                    retVal = "تصویر بنر تبلیغاتی صفحه تولیدکنندگان - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.SupplierDetail:
                    retVal = "تصویر بنر تبلیغاتی صفحه جزییات تولیدکننده - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.WeightTable:
                    retVal = "تصویر بنر تبلیغاتی صفحه جدول وزنی - سایز 197*596 پیکسل";
                    break;
                case Position.ArchiveTable:
                    retVal = "تصویر بنر تبلیغاتی صفحه آرشیو قیمت ها - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.PriceList:
                    retVal = "تصویر بنر تبلیغاتی پایین صفحه لیست قیمت ها - سایز بزرگ 354*767 پیکسل و سایز کوچیک 166*414 پیکسل";
                    break;
                case Position.PriceList_Pic:
                    retVal = "تصویر بنر تبلیغاتی بالای صفحه لیست قیمت ها - سایز 222*378 پیکسل";
                    break;
                case Position.PriceList_Header:
                    retVal = "تصویر هدر بالای صفحه لیست قیمت ها - سایز 362*1600 پیکسل";
                    break;

                default:
                    break;
            }
            return retVal;
        }
    }
    public class Comment
    {
        public enum Status { InProgress = 1, Accepted = 2 }

        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case Status.InProgress:
                    retVal = "در حال بررسی";
                    break;
                case Status.Accepted:
                    retVal = "تایید شده";
                    break;
                default:
                    break;
            }
            return retVal;
        }
        public enum ObjectType { News = 1, Article = 2, Product = 3, VideoGallery = 4 }

        public static string ObjectTypePersianName(ObjectType objectType)
        {
            string retVal = string.Empty;
            switch (objectType)
            {
                case ObjectType.News:
                    retVal = "اخبار";
                    break;
                case ObjectType.Article:
                    retVal = "مقالات";
                    break;
                case ObjectType.Product:
                    retVal = "محصولات";
                    break;
                case ObjectType.VideoGallery:
                    retVal = "گالری ویدئو";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class DynamicField
    {
        public enum DbType { Text = 1, Integer = 2, Floating = 3, SingleItem = 4, MultiItem = 5, File = 6, Date = 7, Boolean = 8 };

        public static string DbTypePersianName(DbType dbtype)
        {
            string retVal = string.Empty;
            switch (dbtype)
            {
                case DbType.Text:
                    retVal = "متنی";
                    break;
                case DbType.Integer:
                    retVal = "عدد صحیح";
                    break;
                case DbType.Floating:
                    retVal = "عدد اعشاری";
                    break;
                case DbType.SingleItem:
                    retVal = "تک آیتمی";
                    break;
                case DbType.MultiItem:
                    retVal = "چند آیتمی";
                    break;
                case DbType.File:
                    retVal = "فایل";
                    break;
                case DbType.Date:
                    retVal = "تاریخ";
                    break;
                case DbType.Boolean:
                    retVal = "بلی/خیر";
                    break;
            }
            return retVal;
        }

    }

    public class DynamicFormFieldInstance
    {
        public enum Status { NotViewed = 1, InProgress = 2, Archived = 3 }
        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case Status.NotViewed:
                    retVal = "بررسی نشده";
                    break;
                case Status.InProgress:
                    retVal = "در حال بررسی";
                    break;
                case Status.Archived:
                    retVal = "آرشیو شده";
                    break;
            }
            return retVal;
        }
    }

    public class DynamicFormFiled
    {
        public enum FiledType { TextBox = 1, DropDownList = 2, CheckBoxList = 3, RadioButtonList = 4, FileUpload = 5, TextArea = 6, Integer = 7, Floating = 8, Mobile = 9, Email = 10 }
        public static string FiledTypePersianName(FiledType filedType)
        {
            string retVal = string.Empty;
            switch (filedType)
            {
                case FiledType.TextBox:
                    retVal = "متنی";
                    break;
                case FiledType.Integer:
                    retVal = "مقادیر عددی صحیح";
                    break;
                case FiledType.Floating:
                    retVal = "مقادیر عددی اعشاری";
                    break;
                case FiledType.Mobile:
                    retVal = "تلفن همراه";
                    break;
                case FiledType.Email:
                    retVal = "ایمیل";
                    break;
                case FiledType.DropDownList:
                    retVal = "لیست کشویی";
                    break;
                case FiledType.CheckBoxList:
                    retVal = "لیست انتخابی چندتایی";
                    break;
                case FiledType.RadioButtonList:
                    retVal = "لیست انتخابی تکی";
                    break;
                case FiledType.FileUpload:
                    retVal = "فایل";
                    break;
                case FiledType.TextArea:
                    retVal = "متنی (چند سطری)";
                    break;
            }
            return retVal;
        }
        public enum FileFormat { jpg = 0, jpeg = 1, png = 2, txt = 3, doc = 4, docx = 5, pdf = 6, xls = 7, xlsx = 8, zip = 9 }
        public static string FileFormatPersianName(FileFormat fileFormat)
        {
            string retVal = string.Empty;
            switch (fileFormat)
            {
                case FileFormat.jpg:
                    retVal = "jpg";
                    break;
                case FileFormat.jpeg:
                    retVal = "jpeg";
                    break;
                case FileFormat.png:
                    retVal = "png";
                    break;
                case FileFormat.txt:
                    retVal = "txt";
                    break;
                case FileFormat.doc:
                    retVal = "doc";
                    break;
                case FileFormat.docx:
                    retVal = "docx";
                    break;
                case FileFormat.pdf:
                    retVal = "pdf";
                    break;
                case FileFormat.xls:
                    retVal = "xls";
                    break;
                case FileFormat.xlsx:
                    retVal = "xlsx";
                    break;
                case FileFormat.zip:
                    retVal = "zip";
                    break;
            }
            return retVal;
        }
    }

    public class Faq
    {
        public enum Writer { Admin = 1, User = 2 }

        public static string WriterPersianName(Writer writer)
        {
            string retVal = string.Empty;
            switch (writer)
            {
                case Writer.Admin:
                    retVal = "مدیر";
                    break;
                case Writer.User:
                    retVal = "کاربر";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class LogOperation
    {
        public enum Operation { Insert = 1, Update = 2, Delete = 3, Login = 4, Logout = 5, ChangePassword = 6 }

        public static string OperationPersianName(Operation operation)
        {
            string retVal = string.Empty;
            switch (operation)
            {
                case Operation.Insert:
                    retVal = "درج";
                    break;
                case Operation.Update:
                    retVal = "بروز رسانی";
                    break;
                case Operation.Delete:
                    retVal = "حذف";
                    break;
                case Operation.Login:
                    retVal = "ورود به سایت";
                    break;
                case Operation.Logout:
                    retVal = "خروج از سایت";
                    break;
                case Operation.ChangePassword:
                    retVal = "تغییر کلمه عبور";
                    break;
            }
            return retVal;
        }
    }

    public class PollOption
    {
        public enum FiledType { TextBox = 1, RadioButton = 2, CheckBox = 3 }

        public static string FiledTypePersianName(FiledType type)
        {
            string retVal = string.Empty;
            switch (type)
            {
                case FiledType.TextBox:
                    retVal = "متنی";
                    break;
                case FiledType.RadioButton:
                    retVal = "تک انتخابی";
                    break;
                case FiledType.CheckBox:
                    retVal = "چند انتخابی";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }
    public class UserMassage
    {
        public enum Status { UnRead = 1, Read = 2 };

        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case Status.UnRead:
                    retVal = "خوانده نشده";
                    break;
                case Status.Read:
                    retVal = "خوانده شده";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }
    public class SiteSetting
    {
        public enum Title { Vat = 1, Toll = 2, LowSendPrice = 3, CourierPrice = 4, ForehandPrice = 5, CustomPrice = 6, NumberSms = 7, UserSms = 8, PassSms = 9, Telegram = 10, };
        public static string TitlePersianName(Title title)
        {
            string retVal = string.Empty;
            switch (title)
            {
                case Title.Vat:
                    retVal = "مالیات (درصد)";
                    break;
                case Title.Toll:
                    retVal = "عوارض (درصد)";
                    break;
                case Title.LowSendPrice:
                    retVal = "هزینه ارسال رایگان";
                    break;
                case Title.CourierPrice:
                    retVal = "هزینه ارسال باربری";
                    break;
                case Title.ForehandPrice:
                    retVal = "هزینه ارسال با پست پیشتاز";
                    break;
                case Title.CustomPrice:
                    retVal = "هزینه ارسال با پست سفارشی";
                    break;
                case Title.NumberSms:
                    retVal = "شماره فرستنده پیامک";
                    break;
                case Title.UserSms:
                    retVal = "نام کاربری پنل اس امس";
                    break;
                case Title.PassSms:
                    retVal = "پسورد پنل اس امس";
                    break;
                case Title.Telegram:
                    retVal = "لینک تلگرام";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class UserInfo
    {
        public enum UserType { Admin = 1, AdminLevelTow = 2, User = 3, LegalUser = 4, Supplier = 5 };
        public static string UserTypePersianName(UserType userType)
        {
            string retVal = string.Empty;
            switch (userType)
            {
                case UserType.Admin:
                    retVal = "مدیر سایت";
                    break;
                case UserType.AdminLevelTow:
                    retVal = "مدیران سطح دوم";
                    break;
                case UserType.User:
                    retVal = "شخص حقیقی";
                    break;
                case UserType.LegalUser:
                    retVal = "شخص حقوقی";
                    break;
                case UserType.Supplier:
                    retVal = "تامین کننده";
                    break;
                default:
                    break;
            }
            return retVal;
        }
        public enum UserTypeSite { User = 1, Store = 2, Financial = 3, Logistic = 4 };
        public static string UserTypeSitePersianName(UserTypeSite userTypeSite)
        {
            string retVal = string.Empty;
            switch (userTypeSite)
            {
                case UserTypeSite.User:
                    retVal = "کاربران";
                    break;
                case UserTypeSite.Store:
                    retVal = "فروشگاه";
                    break;
                case UserTypeSite.Financial:
                    retVal = "مالی";
                    break;
                case UserTypeSite.Logistic:
                    retVal = "تیم لجستیک و حمل و نقل";
                    break;
                default:
                    break;
            }
            return retVal;
        }
        public enum Gender { Man = 1, Woman = 2 }
        public static string GenderPersianName(Gender gender)
        {
            string retVal = "";
            switch (gender)
            {
                case Gender.Woman:
                    retVal = "زن";
                    break;
                case Gender.Man:
                    retVal = "مرد";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum Marriage { Single = 1, Married = 2 }
        public static string MarriagePersianName(Marriage marriage)
        {
            string retVal = "";
            switch (marriage)
            {
                case Marriage.Single:
                    retVal = "مجرد";
                    break;
                case Marriage.Married:
                    retVal = "متاهل";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class UserOrder
    {
        public enum Status { Reject = 1, InProgress = 2, InProduce = 3, InSend = 4, Sent = 5 };

        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case Status.Reject:
                    retVal = "برگشت";
                    break;
                case Status.InProgress:
                    retVal = "در حال بررسی";
                    break;
                case Status.InProduce:
                    retVal = "در حال تهیه";
                    break;
                case Status.InSend:
                    retVal = "در حال ارسال";
                    break;
                case Status.Sent:
                    retVal = "ارسال شده";
                    break;
                default:
                    break;
            }
            return retVal;
        }

        public enum PayType { MoneyInPlace = 1, Pos = 2, Online = 3, Cart = 4, Fish = 5, Deposit = 6 };

        public static string PayTypePersianName(PayType payType)
        {
            string retVal = string.Empty;
            switch (payType)
            {
                case PayType.MoneyInPlace:
                    retVal = "پرداخت نقدی در محل";
                    break;
                case PayType.Pos:
                    retVal = "پرداخت بوسیله کارت خوان سیار در محل";
                    break;
                case PayType.Online:
                    retVal = "پرداخت اینترنتی (آنلاین) با کلیه کارتهای عضو شتاب";
                    break;
                case PayType.Cart:
                    retVal = "کارت به کارت";
                    break;
                case PayType.Fish:
                    retVal = "واریز به حساب";
                    break;
                case PayType.Deposit:
                    retVal = "پرداخت ودیعه";
                    break;
                default:
                    break;

            }
            return retVal;
        }

        public enum SendType { Courier = 1, Customer = 2 };

        public static string SendTypePersianName(SendType sendtype)
        {
            string retVal = string.Empty;
            switch (sendtype)
            {
                case SendType.Courier:
                    retVal = "انتخاب باربری توسط آسرون";
                    break;
                case SendType.Customer:
                    retVal = "انتخاب باربری توسط مشتری";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Tables
    {
        public enum Status { Hide = 1, Show = 2 };

        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case Tables.Status.Hide:
                    retVal = "عدم نمایش";
                    break;
                case Tables.Status.Show:
                    retVal = "نمایش";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class CheckStatus
    {
        public enum Status { Hide = 1, Show = 2 };

        public static string StatusPersianName(Status status)
        {
            string retVal = string.Empty;
            switch (status)
            {
                case CheckStatus.Status.Hide:
                    retVal = "در حال بررسی";
                    break;
                case CheckStatus.Status.Show:
                    retVal = "بررسی شده";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Utility
    {
        public static DataTable GetEnumPersian(string EnumClass, string EnumName)
        {
            DataTable retVal = new DataTable();
            retVal.Columns.Add("Id");
            retVal.Columns.Add("Title");
            Type type = Type.GetType("AllEnums." + EnumClass);
            var methodInfo = type.GetMethod(EnumName + "PersianName");
            Type TEnum = Type.GetType("AllEnums." + EnumClass + "+" + EnumName);
            var values = Enum.GetValues(TEnum);
            var names = Enum.GetNames(TEnum);
            for (int i = 0; i < names.Length; i++)
            {
                var row = retVal.NewRow();
                row["Id"] = Convert.ToByte(Enum.Parse(TEnum, Convert.ToString(values.GetValue(i))));
                object classInstance = Activator.CreateInstance(type, null);
                if (methodInfo != null)
                    row["Title"] = methodInfo.Invoke(classInstance, new object[] { values.GetValue(i) });
                retVal.Rows.Add(row);
            }
            return retVal;//
        }

        public static string[] GetEnumNames(string EnumClass, string EnumName)
        {
            Type TEnum = Type.GetType("AllEnums." + EnumClass + "+" + EnumName);
            return Enum.GetNames(TEnum);
        }

        public static Array GetEnumValues(string EnumClass, string EnumName, string EnumValue)
        {
            Type TEnum = Type.GetType("AllEnums." + EnumClass + "+" + EnumName + "+" + EnumValue);
            return Enum.GetValues(TEnum);
        }
    }

    public class Post
    {
        public enum Weight { cost250 = 1, cost500 = 2, cost1000 = 3, cost2000 = 4, kg = 5 };

        public static string WeightPersianName(Weight weight)
        {
            string retVal = string.Empty;
            switch (weight)
            {
                case Weight.cost250:
                    retVal = "تا 250 گرم";
                    break;
                case Weight.cost500:
                    retVal = "از 251 تا 500 گرم";
                    break;
                case Weight.cost1000:
                    retVal = "از 501 تا 1000 گرم";
                    break;
                case Weight.cost2000:
                    retVal = "از 1001 تا 2000 گرم";
                    break;
                case Weight.kg:
                    retVal = "هر کیلوگرم اضافه و کسر آن";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Career
    {
        public enum Military { ServedCard = 1, ExemptMedical = 2, Subject = 3, NonTaxable = 4, Other = 5 }

        public static string MilitaryPersianName(Military military)
        {
            string retVal = string.Empty;
            switch (military)
            {
                case Military.ServedCard:
                    retVal = "دارای کارت پایان خدمت";
                    break;
                case Military.ExemptMedical:
                    retVal = "معاف کامل پزشکی";
                    break;
                case Military.Subject:
                    retVal = "مشمول";
                    break;
                case Military.NonTaxable:
                    retVal = "غیر مشمول (ویژه بانوان)";
                    break;
                case Military.Other:
                    retVal = "سایر موارد";
                    break;
                default:
                    break;
            }
            return retVal;
        }
        public enum Education { PhD = 1, MA = 2, Bachelor = 3, AssociateDegree = 4, Diploma = 5, Cycle = 6 }

        public static string EducationPersianName(Education education)
        {
            string retVal = string.Empty;
            switch (education)
            {
                case Education.PhD:
                    retVal = "دکترا";
                    break;
                case Education.MA:
                    retVal = "فوق لیسانس";
                    break;
                case Education.Bachelor:
                    retVal = "لیسانس";
                    break;
                case Education.AssociateDegree:
                    retVal = "فوق دیپلم";
                    break;
                case Education.Diploma:
                    retVal = "دیپلم";
                    break;
                case Education.Cycle:
                    retVal = "سیکل";
                    break;
                default:
                    break;
            }
            return retVal;
        }
        public enum Position { SaleManager = 1, ItExpert = 2, }
        public static string PositionPersianName(Position position)
        {
            string retVal = string.Empty;
            switch (position)
            {
                case Position.SaleManager:
                    retVal = "مدیر فروش";
                    break;
                case Position.ItExpert:
                    retVal = "کارشناس فروش";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class ProductGallery
    {
        public enum Type { Picture = 1, Video = 2 };

        public static string TypePersianName(Type type)
        {
            string retVal = string.Empty;
            switch (type)
            {
                case Type.Picture:
                    retVal = "تصویر";
                    break;
                case Type.Video:
                    retVal = "ویدئو";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class ProductGroupProperty
    {
        public enum Type { Price = 1, Weight = 2, Both = 3 };

        public static string TypePersianName(Type type)
        {
            string retVal = string.Empty;
            switch (type)
            {
                case Type.Price:
                    retVal = "نمایش در جدول قیمت";
                    break;
                case Type.Weight:
                    retVal = "نمایش در جدول وزنی ";
                    break;
                case Type.Both:
                    retVal = "نمایش در هر دو ";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Product
    {
        public enum DefaultPrice { Factory = 1, Tehran = 2, Qom = 3 };

        public static string DefaultPricePersianName(DefaultPrice defaultprice)
        {
            string retVal = string.Empty;
            switch (defaultprice)
            {
                case DefaultPrice.Factory:
                    retVal = "درب کارخانه";
                    break;
                case DefaultPrice.Tehran:
                    retVal = "انبار تهران ";
                    break;
                case DefaultPrice.Qom:
                    retVal = "انبار قم ";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }
    public class ProductColor
    {
        public enum DefaultUnit
        {
            Kilo = 1, Meter = 2, SquareMeter = 3,
            Number = 4, Leaf = 5, Roll = 6, Branch = 7, Ring = 8,

        };

        public static string DefaultUnitPersianName(DefaultUnit defaultunit)
        {
            string retVal = string.Empty;
            switch (defaultunit)
            {
                case DefaultUnit.Kilo:
                    retVal = "کیلو";
                    break;
                case DefaultUnit.Meter:
                    retVal = "متر";
                    break;
                case DefaultUnit.SquareMeter:
                    retVal = "متر مربع";
                    break;
                case DefaultUnit.Number:
                    retVal = "تعداد (عدد)";
                    break;
                case DefaultUnit.Leaf:
                    retVal = "برگ";
                    break;
                case DefaultUnit.Roll:
                    retVal = "رول";
                    break;
                case DefaultUnit.Branch:
                    retVal = "شاخه";
                    break;
                case DefaultUnit.Ring:
                    retVal = "حلقه";
                    break;
                default:
                    break;
            }
            return retVal;
        }
    }

    public class Customer
    {
        public enum Type
        {
            Customer = 1, Cooperation = 2 

        };

        public static string TypePersianName(Type Type)
        {
            string retVal = string.Empty;
            switch (Type)
            {
                case Type.Customer:
                    retVal = "مشتری";
                    break;
                case Type.Cooperation:
                    retVal = "همکار";
                    break;
            }
            return retVal;
        }
    }


}
