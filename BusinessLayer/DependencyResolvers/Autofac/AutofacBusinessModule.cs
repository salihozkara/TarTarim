using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Castle.DynamicProxy;
using CoreLayer.Utilities.Interceptors;
using CoreLayer.Utilities.Security.JWT;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            //auth
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<EfQuestionCategoryDal>().As<IQuestionCategoryDal>();
            builder.RegisterType<QuestionCategoryManager>().As<IQuestionCategoryService>();

            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>();
            builder.RegisterType<QuestionManager>().As<IQuestionService>();

            builder.RegisterType<EfQuestionSubCategoryDal>().As<IQuestionSubCategoryDal>();
            builder.RegisterType<QuestionSubCategoryManager>().As<IQuestionSubCategoryService>();

            builder.RegisterType<EfReplyAnswerDal>().As<IReplyAnswerDal>();
            builder.RegisterType<ReplyAnswerManager>().As<IReplyAnswerService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();

            builder.RegisterType<EfAnswerDal>().As<IAnswerDal>();
            builder.RegisterType<AnswerManager>().As<IAnswerService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
