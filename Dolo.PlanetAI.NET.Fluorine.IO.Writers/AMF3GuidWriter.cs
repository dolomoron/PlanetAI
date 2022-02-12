using System;

namespace Dolo.PlanetAI.NET.Fluorine.IO.Writers;

internal class AMF3GuidWriter : IAMFWriter
{
	public bool IsPrimitive => true;

	public void WriteData(AMFWriter writer, object data)
	{
		writer.WriteAMF3String(((Guid)data).ToString());
	}
}
