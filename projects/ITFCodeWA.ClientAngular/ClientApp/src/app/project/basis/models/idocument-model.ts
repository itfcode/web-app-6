import { IEntitySyncModel } from "./imodel";

export interface IDocumentModel extends IEntitySyncModel {
  number: number;
  date: Date;
  comment: string;
  commited: boolean;
  marked: boolean;
  authorId: number;
  authorFullName: string;
}
