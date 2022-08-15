
export interface IModel<TKey> {
  id: TKey;
}

export interface IEntityModel extends IModel<number> {
}

export interface IEntitySyncModel extends IModel<string> {
}

