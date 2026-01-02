using AGP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGP
{

    /// <summary>
    /// Classe responsável por aplicar filtros cumulativos
    /// sobre a entidade Processo.
    /// </summary>
    public class ProcessoFilter
    {
     /// <summary>
     /// Aplica filtros dinâmicos à consulta de Processos
     /// com base nos parâmetros informados.
     /// Apenas os filtros diferentes de null são aplicados.
     /// </summary>
     /// <param name="query">
     /// Consulta base (IQueryable) sobre a entidade Processo.
     /// Normalmente vem de db.Processos.
     /// </param>
     /// <param name="categoria">Categoria selecionada no ComboBox</param>
     /// <param name="estado">Estado selecionado no ComboBox</param>
     /// <param name="prioridade">Prioridade selecionada no ComboBox</param>
     /// <param name="funcionario">Funcionário selecionado no ComboBox</param>
     /// <param name="cliente">Cliente selecionado no ComboBox</param>
     /// <returns>
     /// IQueryable contendo todos os filtros aplicados de forma cumulativa
     /// </returns>
        public IQueryable<Processo> FiltrarProcessos(
            IQueryable<Processo> query,
            Categoria categoria,
            Estado estado,
            Prioridade prioridade,
            Funcionario funcionario,
            Cliente cliente)
        {
            // Aplica filtro por Categoria, caso exista
            if (categoria != null)
            {
                query = query.Where(p => p.CategoriaId == categoria.Id);
            }

            // Aplica filtro por Estado, caso exista
            if (estado != null)
            {
                query = query.Where(p => p.Estado == estado.Id);
            }

            // Aplica filtro por Prioridade, caso exista
            if (prioridade != null)
            {
                query = query.Where(p => p.PrioridadeId == prioridade.Id);
            }

            // Aplica filtro por Funcionário, caso exista
            if (funcionario != null)
            {
                query = query.Where(p => p.FuncionarioId == funcionario.Id);
            }

            // Aplica filtro por Cliente, caso exista
            if (cliente != null)
            {
                query = query.Where(p => p.ClienteId == cliente.Id);
            }

            // Retorna a query com todos os filtros aplicados
            return query;
        }
    }
}

