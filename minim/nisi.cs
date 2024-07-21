// Assuming GuiTextureSettings is a class or struct
GuiTextureSettings settings = new GuiTextureSettings();
string json = JsonUtility.ToJson(settings);
m_Target.userData = json;
