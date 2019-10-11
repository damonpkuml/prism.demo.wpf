using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace UsingCompositeCommands.Core {
    public interface IApplicationCommands {
        CompositeCommand CompositeCommand { get; }
    }
    public class ApplicationCommands : IApplicationCommands {
        private CompositeCommand _compositeCommand = new CompositeCommand();

        public CompositeCommand CompositeCommand {
            get { return _compositeCommand; }
        }
    }
}
