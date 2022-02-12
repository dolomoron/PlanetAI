namespace Dolo.PlanetAI.NET.Fluorine.IO.Writers;

internal class AMF3CacheableObjectWriter : IAMFWriter
{
	public bool IsPrimitive => true;

	public void WriteData(AMFWriter writer, object data)
	{
		writer.WriteAMF3Data((data as CacheableObject).Object);
	}
}
