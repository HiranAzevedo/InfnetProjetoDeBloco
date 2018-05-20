﻿using CourseRating.Domain.Entities;
using CourseRating.Web.ViewModels;

namespace CourseRating.Web.Mapper
{
    public class AlunoMapper
    {
        public static Aluno ExtractFromViewModel(TurmaViewModel viewModel)
        {
            var aluno = new Aluno
            {
                Email = viewModel.Email,
                Matricula = viewModel.Matricula,
                //TODO Adicionar todos os atributos
            };
            return aluno;
        }


        public static TurmaViewModel BuildViewModelFrom(Aluno aluno)
        {
            var viewModel = new TurmaViewModel
            {
                Email = aluno.Email,
                Matricula = aluno.Matricula,
                //TODO Adicionar todos os atributos
            };

            return viewModel;
        }
    }
}