using System;
using System.Collections.Generic;
using WebApiProdutos.Interfaces;
using WebApiProdutos.Models;

namespace WebApiProdutos.Service
{
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private List<Estudante> estudantes = new List<Estudante>();
        private int _nextId = 1;

        public EstudanteRepositorio()
        {
            Add(new Estudante { Nome = "Macoratti", Id = 1, Genero = "Masculino", Idade = 55 });
            Add(new Estudante { Nome = "Jefferson", Id = 2, Genero = "Masculino", Idade = 24 });
            Add(new Estudante { Nome = "Miriam", Id = 3, Genero = "Feminino", Idade = 35 });
            Add(new Estudante { Nome = "Janice", Id = 4, Genero = "Feminino", Idade = 21 });
            Add(new Estudante { Nome = "Jessica", Id = 5, Genero = "Feminino", Idade = 25 });
        }
        public IEnumerable<Estudante> GetAll()
        {
            return estudantes;
        }
        public Estudante Get(int id)
        {
            return estudantes.Find(s => s.Id == id);
        }
        public bool Add(Estudante estudante)
        {
            bool addResult = false;
            if(estudante == null)
            {
                return addResult;
            }
            int index = estudantes.FindIndex(s => s.Id == estudante.Id);
            if(index == -1)
            {
                estudantes.Add(estudante);
                addResult = true;
                return addResult;
            }
            else
            {
                return addResult;
            }
        }
        public void Remove(int id)
        {
            estudantes.RemoveAll(s => s.Id == id);
        }
        public bool Update(Estudante estudante)
        {
            if(estudante == null)
            {
                throw new ArgumentNullException("estudante");
            }
            int index = estudantes.FindIndex(s => s.Id == estudante.Id);
            if(index == -1)
            {
                return false;
            }
            estudantes.RemoveAt(index);
            estudantes.Add(estudante);
            return true;
        }

    }
}