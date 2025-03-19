class CompositeArtefact : Artefact
{
  protected List<Artefact> _children = new List<Artefact>();
  public CompositeArtefact(string name, int weight, int powerBuf)
    : base(name, weight, powerBuf) {}

  public virtual void AddArtefact(Artefact artefact)
  {
    this._children.Add(artefact);
  }

  public virtual void RemoveArtefact(Artefact artefact)
  {
    this._children.Remove(artefact);
  }

  public override int GetWeight()
  {
    return this._children.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
  }

  public override int GetPowerBuf()
  {
    return this._children.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
  }
}

class ArtefactContainer : CompositeArtefact
{
  public ArtefactContainer(string name) : base(name, 0, 0) {}

  public override int GetCount()
  {
    return this._children.Aggregate(0, (sum, next) => sum += next.GetCount());
  }
}

class ArtefactWithArtefacts : CompositeArtefact
{
  public ArtefactWithArtefacts(string name, int weight, int powerBuf) : base(name, weight, powerBuf) {}

  public override int GetCount()
  {
    return this._children.Aggregate(1, (sum, next) => sum += next.GetCount());
  }
}