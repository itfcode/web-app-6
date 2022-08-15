import { IReferenceModel } from "../../../basis/models";

export interface IPersonModel extends IReferenceModel {
  firstName: string;
  middleName: string;
  lastName: string;
  fullName: string;
}
