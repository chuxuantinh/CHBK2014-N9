using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CHBK2014_N9.Common
{
  public  class MenuButton
    {

        private ItemCommand _add;

        private ItemCommand _change;

        private ItemCommand _save;

        private ItemCommand _saveAndNew;

        private ItemCommand _saveAndClose;

        private ItemCommand _cancel;

        private ItemCommand _delete;

        private ItemCommand _refresh;

        private ItemCommand _undo;

        private ItemCommand _redo;

        private ItemCommand _previous;

        private ItemCommand _next;

        private ItemCommand _find;

        private ItemCommand _view;

        private ItemCommand _vaildate;

        private ItemCommand _search;

        private ItemCommand _filter;

        private ItemCommand _searchText;

        private ItemCommand _filterStock;

        private ItemCommand _filterCustomer;

        private ItemCommand _go;

        private ItemCommand _close;

        private ItemCommand _pageSetup;

        private ItemCommand _print;

        private ItemCommand _printPreview;

        private ItemCommand _export;

        private ItemCommand _import;

        private ItemCommand _custom;

        private ItemCommand _task;

        [Category("Bar")]
        [DisplayName("Add")]
        public ItemCommand Add
        {
            get
            {
                return this._add;
            }
            set
            {
                this._add = value;
            }
        }

        public ItemCommand Cancel
        {
            get
            {
                return this._cancel;
            }
            set
            {
                this._cancel = value;
            }
        }

        [Category("Bar")]
        [DisplayName("Change")]
        public ItemCommand Change
        {
            get
            {
                return this._change;
            }
            set
            {
                this._change = value;
            }
        }

        public ItemCommand Close
        {
            get
            {
                return this._close;
            }
            set
            {
                this._close = value;
            }
        }

        public ItemCommand Custom
        {
            get
            {
                return this._custom;
            }
            set
            {
                this._custom = value;
            }
        }

        public ItemCommand Delete
        {
            get
            {
                return this._delete;
            }
            set
            {
                this._delete = value;
            }
        }

        public ItemCommand Export
        {
            get
            {
                return this._export;
            }
            set
            {
                this._export = value;
            }
        }

        public ItemCommand Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
            }
        }

        public ItemCommand FilterCustomer
        {
            get
            {
                return this._filterCustomer;
            }
            set
            {
                this._filterCustomer = value;
            }
        }

        public ItemCommand FilterStock
        {
            get
            {
                return this._filterStock;
            }
            set
            {
                this._filterStock = value;
            }
        }

        public ItemCommand Find
        {
            get
            {
                return this._find;
            }
            set
            {
                this._find = value;
            }
        }

        public bool GClose
        {
            get;
            set;
        }

        public bool GCommand
        {
            get;
            set;
        }

        public bool GExport
        {
            get;
            set;
        }

        public ItemCommand Go
        {
            get
            {
                return this._go;
            }
            set
            {
                this._go = value;
            }
        }

        public bool GOption
        {
            get;
            set;
        }

        public bool GPrint
        {
            get;
            set;
        }

        public bool GRecords
        {
            get;
            set;
        }

        public bool GSearchBar
        {
            get;
            set;
        }

        public bool GSettings
        {
            get;
            set;
        }

        public bool GVaildation
        {
            get;
            set;
        }

        public ItemCommand Import
        {
            get
            {
                return this._import;
            }
            set
            {
                this._import = value;
            }
        }

        public ItemCommand Next
        {
            get
            {
                return this._next;
            }
            set
            {
                this._next = value;
            }
        }

        public ItemCommand PageSetup
        {
            get
            {
                return this._pageSetup;
            }
            set
            {
                this._pageSetup = value;
            }
        }

        public bool PHome
        {
            get;
            set;
        }

        public ItemCommand Previous
        {
            get
            {
                return this._previous;
            }
            set
            {
                this._previous = value;
            }
        }

        public ItemCommand Print
        {
            get
            {
                return this._print;
            }
            set
            {
                this._print = value;
            }
        }

        public ItemCommand PrintPreview
        {
            get
            {
                return this._printPreview;
            }
            set
            {
                this._printPreview = value;
            }
        }

        public bool PTool
        {
            get;
            set;
        }

        public ItemCommand Redo
        {
            get
            {
                return this._redo;
            }
            set
            {
                this._redo = value;
            }
        }

        public ItemCommand Refresh
        {
            get
            {
                return this._refresh;
            }
            set
            {
                this._refresh = value;
            }
        }

        public ItemCommand Save
        {
            get
            {
                return this._save;
            }
            set
            {
                this._save = value;
            }
        }

        public ItemCommand SaveAndClose
        {
            get
            {
                return this._saveAndClose;
            }
            set
            {
                this._saveAndClose = value;
            }
        }

        public ItemCommand SaveAndNew
        {
            get
            {
                return this._saveAndNew;
            }
            set
            {
                this._saveAndNew = value;
            }
        }

        public ItemCommand Search
        {
            get
            {
                return this._search;
            }
            set
            {
                this._search = value;
            }
        }

        public ItemCommand SearchText
        {
            get
            {
                return this._searchText;
            }
            set
            {
                this._searchText = value;
            }
        }

        public ItemCommand Task
        {
            get
            {
                return this._task;
            }
            set
            {
                this._task = value;
            }
        }

        public ItemCommand Undo
        {
            get
            {
                return this._undo;
            }
            set
            {
                this._undo = value;
            }
        }

        public ItemCommand Vaildate
        {
            get
            {
                return this._vaildate;
            }
            set
            {
                this._vaildate = value;
            }
        }

        public ItemCommand View
        {
            get
            {
                return this._view;
            }
            set
            {
                this._view = value;
            }
        }

        public MenuButton()
        {
            this._task = new ItemCommand();
            this._custom = new ItemCommand();
            this._import = new ItemCommand();
            this._export = new ItemCommand();
            this._printPreview = new ItemCommand();
            this._print = new ItemCommand();
            this._pageSetup = new ItemCommand();
            this._close = new ItemCommand();
            this._go = new ItemCommand();
            this._filterCustomer = new ItemCommand();
            this._filterStock = new ItemCommand();
            this._searchText = new ItemCommand();
            this._filter = new ItemCommand();
            this._search = new ItemCommand();
            this._vaildate = new ItemCommand();
            this._view = new ItemCommand();
            this._find = new ItemCommand();
            this._next = new ItemCommand();
            this._previous = new ItemCommand();
            this._redo = new ItemCommand();
            this._undo = new ItemCommand();
            this._refresh = new ItemCommand();
            this._delete = new ItemCommand();
            this._cancel = new ItemCommand();
            this._saveAndClose = new ItemCommand();
            this._saveAndNew = new ItemCommand();
            this._save = new ItemCommand();
            this._change = new ItemCommand();
            this._add = new ItemCommand();
        }
    }
}
