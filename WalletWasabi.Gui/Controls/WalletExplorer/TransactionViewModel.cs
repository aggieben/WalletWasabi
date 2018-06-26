﻿using ReactiveUI;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Controls.WalletExplorer
{
	public class TransactionViewModel : ViewModelBase
	{
		private TransactionInfo _model;

		public TransactionViewModel(TransactionInfo model)
		{
			_model = model;

			_confirmed = model.WhenAnyValue(x => x.Confirmed).ToProperty(this, x => x.Confirmed, model.Confirmed);
		}

		private readonly ObservableAsPropertyHelper<bool> _confirmed;

		public bool Confirmed
		{
			get { return _confirmed.Value; }
		}

		public string AmountBtc
		{
			get => _model.AmountBtc;
		}

		public string Label
		{
			get => _model.Label;
		}

		public string TransactionId
		{
			get => _model.TransactionId;
		}
	}
}
