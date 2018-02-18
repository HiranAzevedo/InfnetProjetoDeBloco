using CourseRating.Domain.Entities;
using CourseRating.Web.ViewModels;

namespace CourseRating.Web.Mapper
{
    public class AlunoMapper
    {
        public static Aluno ExtractAlunoFromViewModel(AlunoViewModel viewModel)
        {
            var aluno = new Aluno
            {
                Email = viewModel.Email,
                Matricula = viewModel.Matricula,
                Status =  viewModel.Status,
                //TODO Adicionar todos os atributos
            };
            return aluno;
        }


        public static AlunoViewModel BuildViewModelFrom(Aluno aluno)
        {
            var viewModel = new AlunoViewModel
            {
                Email = aluno.Email,
                Status = aluno.Status,
                Matricula = aluno.Matricula,
                //TODO Adicionar todos os atributos
            };

            return viewModel;
        }
    }
}