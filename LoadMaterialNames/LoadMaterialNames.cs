//
// pmdの材質名リストを読み込む
// [簡易形式]LoadMaterialNames.cx
//
// pmdデータと同じフォルダにある txt ファイル
string materiallist = string.Format(@"{0}\{1}.txt", Path.GetDirectoryName(pmx.FilePath), Path.GetFileNameWithoutExtension(pmx.FilePath));

// 材質名リストを一行ずつ読み込んでセットする
using (StreamReader reader = new StreamReader(materiallist, System.Text.Encoding.Default))
{
    int i = 0;
    while (reader.Peek() >= 0)
    {
        string materialname = reader.ReadLine();
        if (i < material.Count)
        {
            material[i].Name = materialname;
        }
        i++;
    }
}
// 結果を反映
connect.Pmx.Update(pmx);
// 材質リストの更新
connect.Form.UpdateList(UpdateObject.Material);
