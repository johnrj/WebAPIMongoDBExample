﻿using System.Collections.Generic;
using DesafioStone.Models;
using MongoDB.Bson;

namespace DesafioStone.Repository
{
    public interface IUtilizacaoRepository
    {
        Utilizacao Apagar(ObjectId id);
        Utilizacao Atualizar(Utilizacao obj);
        Utilizacao Inserir(Utilizacao obj);
        Utilizacao Obter(ObjectId id);
        List<Utilizacao> ObterTodos();
    }
}