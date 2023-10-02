using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    public class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.Ok_button += new EventHandler<EventArgs>(CheckPassword);
        }
        private void CheckPassword(object sender, EventArgs e)
        {
            _model.Pass = _view.Password;
            _model.CheckPassword();
        }
    }
}
