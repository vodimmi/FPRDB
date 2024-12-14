﻿using PRDB_Sqlite.DAL;
using System.Collections.Generic;

namespace PRDB_Sqlite.BLL
{
    public class ProbTuple
    {
        #region Properties
        // Tập các giá trị bộ ba xác suất trên một tuple
        public List<ProbTriple> Triples { get; set; }
        #endregion

        #region Methods
        public ProbTuple()
        {
            this.Triples = new List<ProbTriple>();
        }

        public ProbTuple(ProbTuple tuple)
        {
            // TODO: Complete member initialization
            this.Triples = new List<ProbTriple>();
            foreach (ProbTriple item in tuple.Triples)
            {
                ProbTriple triple = new ProbTriple(item);
                this.Triples.Add(triple);
            }
        }
        #endregion

        internal List<ProbTuple> getAllTypleByRelationName(string relationname, int nTriples)
        {
            return DALProbTuple.getAllTypleByRelationName(relationname, nTriples);
        }

        internal void DeleteTypeById()
        {
            DALProbTuple.DeleteTypeById(this);
        }
    }
}
