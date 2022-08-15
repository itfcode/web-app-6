import { IReferenceModel } from "../../../basis/models";

export interface IFoodModel extends IReferenceModel {
  proteins: number;
  fats: number;
  carbohydrates: number;
  calories: number;
}
