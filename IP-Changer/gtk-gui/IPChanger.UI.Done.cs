
// This file has been generated by the GUI designer. Do not modify.
namespace IPChanger.UI
{
	public partial class Done
	{
		private global::Gtk.Label message;
		
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget IPChanger.UI.Done
			this.Name = "IPChanger.UI.Done";
			this.Title = "Operation Compleated";
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-info", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Internal child IPChanger.UI.Done.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.message = new global::Gtk.Label ();
			this.message.Name = "message";
			this.message.LabelProp = "label1";
			w1.Add (this.message);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.message]));
			w2.Position = 0;
			// Internal child IPChanger.UI.Done.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-ok";
			this.AddActionWidget (this.buttonCancel, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 473;
			this.DefaultHeight = 128;
			this.Show ();
		}
	}
}
