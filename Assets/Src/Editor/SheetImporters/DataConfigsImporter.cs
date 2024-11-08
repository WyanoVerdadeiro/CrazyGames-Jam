using Game.Configs;
using GameLoversEditor.GoogleSheetImporter;

namespace Game.SheetImporters
{
	/// <inheritdoc />
	public class DataConfigsImporter : GoogleSheetConfigsImporter<DataConfig, DataConfigs>
	{
		/// <inheritdoc />
		public override string GoogleSheetUrl => "https://docs.google.com/spreadsheets/d/1niZetdATgeUv786cV0IHIl0TMK4-JKbEmGiySsAn-vc/edit?gid=558488968#gid=558488968";
	}
}