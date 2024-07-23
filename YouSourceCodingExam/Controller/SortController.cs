using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouSourceCodingExam.Model;

namespace YouSourceCodingExam.Controller
{
    public class SortController
    {
        private readonly SortModel _model;
        private ISortStrategy _strategy;

        public SortController(SortModel model)
        {
            _model = model;
        }

        public void SetSortStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sort()
        {
            if (_strategy != null)
            {
                _model.Sorted = _strategy.Sort(_model.Input);
            }
        }

        public void UpdateModel(string input)
        {
            _model.Input = input;
        }

        public string GetSortedString()
        {
            return _model.Sorted;
        }
    }

}
